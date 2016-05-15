(function (angular) {
    'use strict';

    angular.module('controlSystem').service('exerciseService', exerciseService);

    exerciseService.$inject = ['$http'];

    function exerciseService($http) {
        this.getAssignments = function() {
            return $http({
                url: 'api/assignment',
                method: 'GET'
            });
        };

        this.addHistory = function(history) {
            return $http({
                url: 'api/assignment/addHistory',
                method: 'POST',
                data: history
            });
        };

    }
}(angular));
