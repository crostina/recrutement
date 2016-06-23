'use strict';

angular.module('Grid')
.directive('tile', function() {
  return {
    restrict: 'A',
    scope: {
      ngModel: '='
    },
    templateUrl: '/Templates/2048/tile.html'
  };
});