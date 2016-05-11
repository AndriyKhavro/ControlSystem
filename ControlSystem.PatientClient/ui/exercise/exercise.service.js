(function (angular) {
    'use strict';

    angular.module('controlSystem').service('controlSystem.exerciseService', exerciseService);

    exerciseService.$inject = ['$http'];

    function exerciseService($http) {
        this.getAssignments = function () {
            return $http({
                url: 'api/assignment',
                method: 'GET'
            });
        }
    }
}(angular));
