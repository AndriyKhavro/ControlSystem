(function (angular) {
    'use strict';

    angular.module('controlSystem').component('assignment', {
        templateUrl: 'ui/exercise/assignment.html',
        controller: AssignmentController,
        bindings: {
            exercise: '='
        }
    });

    AssignmentController.$inject = [];
    function AssignmentController() {        
        
    }

}(angular));
