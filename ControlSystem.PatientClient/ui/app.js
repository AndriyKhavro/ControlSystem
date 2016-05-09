(function (angular) {
    "use strict";
    var app = angular.module('controlSystem', ['ui.router']);

    app.run(appRun);

    appRun.$inject = ['$rootScope'];

    function appRun($rootScope) {
        //log all $stateChangeError events since ui-router silently swallows such errors
        $rootScope.$on("$stateChangeError", console.log.bind(console));
    }
}(angular));
