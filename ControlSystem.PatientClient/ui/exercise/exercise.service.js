(function (angular) {
    'use strict';

    angular.module('controlSystem').service('controlSystem.exerciseService', exerciseService);

    exerciseService.$inject = ['$http'];

    function exerciseService($http) {
        this.getAssignments = function () {
            return $http({
                url: 'api/assignment',
                method: 'GET',
                params: {
                    date: new Date(2016, 4, 9, 10, 0, 0),
                    partOfDay: 1
                }
            });
        }
    }
}(angular));
