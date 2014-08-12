﻿/*jslint unparam: true, white: true, browser: true, devel: true */
/*global bettercms */
bettercms.define('bcms.content.tree', ['bcms.jquery', 'bcms', 'bcms.ko.extenders', 'bcms.modal'],
    function ($, bcms, ko, modal) {
    'use strict';

    var tree = {},
        selectors = {
            treeTemplate: '#bcms-contents-tree-template'
        },
        links = {},
        globalization = {},
        treeItemTypes = {
            content: 1,
            region: 2
        };

    // Assign objects to module
    tree.selectors = selectors;
    tree.links = links;
    tree.globalization = globalization;

    function createRegionViewModel(regionModel) {
        var model = new TreeItemViewModel(),
            childContents,
            itemModel,
            i;

        model.title = regionModel.title;
        model.model = regionModel;
        model.type = treeItemTypes.region;

        // Collect child contents
        childContents = regionModel.getChildContents();
        for (i = 0; i < childContents.length; i++) {
            itemModel = createContentViewModel(childContents[i]);

            model.items.push(itemModel);
        }

        model.addContent = function() {
            regionModel.onAddContent();
        };

        return model;
    }

    function createContentViewModel(contentModel) {
        var model = new TreeItemViewModel(),
            childRegions,
            itemModel,
            i;

        model.title = contentModel.title;
        model.model = contentModel;
        model.type = treeItemTypes.content;

        childRegions = contentModel.getChildRegions();
        for (i = 0; i < childRegions.length; i++) {
            itemModel = createRegionViewModel(childRegions[i]);

            model.items.push(itemModel);
        }

        model.editItem = function () {
            contentModel.onEditContent();
        };

        model.deleteItem = function () {
            contentModel.onDeleteContent();
        };

        model.history = function() {
            contentModel.onContentHistory();
        };

        model.configure = function() {
            contentModel.onConfigureContent();
        };

        return model;
    }

    /*
     * Regions/contents tree list view model
     */
    function TreeViewModel(pageModel) {
        var self = this,
            i,
            itemModel;

        self.pageModel = pageModel;
        self.items = ko.observableArray();

        // Collect child regions
        for (i = 0; i < pageModel.regions.length; i++) {
            if (pageModel.regions[i].parentRegion) {
                continue;
            }
            itemModel = createRegionViewModel(pageModel.regions[i]);
            self.items.push(itemModel);
        }

        return self;
    }

    /*
     * Tree item (region or content) view model
     */
    function TreeItemViewModel() {
        var self = this;

        self.items = ko.observableArray();
        self.model = null;
        self.title = null;
        self.type = null;
        self.types = treeItemTypes;

        self.editItem = function () { };
        self.deleteItem = function () { };
        self.addContent = function () { };
        self.history = function () { };
        self.configure = function () { };

        return self;
    }

    /*
    * Opens modal window with all regions / contents listed
    */
    function onEditContentsTree(pageModel) {
        modal.open({
            title: "TODO: TITLE",
            disableAccept: true,
            onLoad: function(dialog) {
                var container = $($(selectors.treeTemplate).html());
                dialog.setContent(container);

                var treeViewModel = new TreeViewModel(pageModel);

                ko.applyBindings(treeViewModel, container.get(0));
            }
        });
    }

    /**
    * Initializes contents tree module.
    */
    tree.init = function () {
        bcms.logger.debug('Initializing contents tree module');
    };

    /**
    * Subscribe to events
    */
    bcms.on(bcms.events.editContentsTree, onEditContentsTree);

    /**
    * Register initialization
    */
    bcms.registerInit(tree.init);

    return tree;
});