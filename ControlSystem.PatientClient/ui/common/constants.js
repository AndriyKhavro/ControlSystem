(function(angular) {
    "use strict";

    angular.module('controlSystem').constant('constant', {
        feeling: {
            noPain: 1,
            mediumPain: 2,
            strongPain: 3
        }
    });
}(angular));