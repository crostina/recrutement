angular.module('app')
.controller('ListController', function ($scope,Candidat) {
    $scope.list = Candidat.query();
    $scope.field = ['FirstName', 'LastName'];

    $scope.stort = function () {
        $scope.sort.field = field;
        $scope.sort.order = !$scope.sort.order;
    };
    $scope.sort.field = 'FirstName';
    $scope.sort.order = false;
});