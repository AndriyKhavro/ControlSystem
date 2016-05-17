(function (angular) {
    "use strict";
    var app = angular.module('controlSystem', ['ui.bootstrap']);


    angular.module('controlSystem').config(config);

    config.$inject = ['$sceDelegateProvider'];
    function config($sceDelegateProvider) {
        $sceDelegateProvider.resourceUrlWhitelist([
          // Allow same origin resource loads.
          'self',
          // Allow loading from our assets domain.  Notice the difference between * and **.
          'http://www.youtube.com/**']);

    }

    app.run();
}(angular));
