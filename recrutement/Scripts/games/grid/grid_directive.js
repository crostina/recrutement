'use strict';

angular.module('Grid')
.directive('grid', function() {
  return {
    restrict: 'A',
    require: 'ngModel',
    scope: {
      ngModel: '='
    },
    templateUrl: '/Templates/2048/grid.html'
  };
});