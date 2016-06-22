angular.module('app')
.controller('candidatController', function ($scope, $rootScope, Candidat, $location) {
    $rootScope.PAGE = 'all';
    $scope.candidats = Candidat.query();
    $scope.fields = ['firstName', 'lastName', 'email'];
    $scope.sort ={};
    $scope.sort.field = 'firstName';
    $scope.sort.order = true;
    $scope.sort = function (field) {
        $scope.sort.field = field;
        $scope.sort.order = !$scope.sort.order;
    };
    $scope.show = function (id) {
        $location.url('/candidat/' + id);
    };

})
.controller('addController', function ($scope, $rootScope, Candidat, $location) {
    $rootScope.PAGE='add';
    //$scope.candidat = new Candidat({
    //    firstName: ['', 'text'],
    //    lastName: ['', 'text'],
    //    email: ['', 'email'],
    //    homePhone: ['', 'tel'],
    //    mobilePhone: ['', 'tel'],
    //    birthday: ['', 'date'],
    //    website: ['', 'url'],
    //    address: ['', 'text'],
    //    enrollmentDate: ['', 'date']

    //});
    $scope.candidat = {};
    $scope.candidat.values = new Candidat({
        firstName: '',
        lastName: '',
        email: '',
        homePhone: '',
        mobilePhone: '',
        birthday: '',
        website: '',
        address: '',
        enrollmentDate: ''

    });
    $scope.candidat.types = {
        firstName: 'text',
        lastName: 'text',
        email: 'email',
        homePhone: 'tel',
        mobilePhone: 'tel',
        birthday: 'date',
        website: 'url',
        address: 'text',
        enrollmentDate: 'date'
    };
    $scope.save = function () {
        if ($scope.newCandidat.$invalid) {
            $scope.$broadcast('record:invalid');
        } else {
            $scope.candidat.values.$save();
            //candidat = new Candidat({
            //    firstName: $scope.candidat.firstName[0],
            //    lastName: $scope.candidat.lastName[0],
            //    email: $scope.candidat.email[0],
            //    homePhone: $scope.candidat.homePhone[0],
            //    mobilePhone: $scope.candidat.mobilePhone[0],
            //    birthday: $scope.candidat.birthday[0],
            //    website: $scope.candidat.website[0],
            //    address: $scope.candidat.address[0],
            //    enrollmentDate: $scope.candidat.enrollmentDate[0]

            //}).$save();

            $location.url('/candidats');
        }
    };
})
.controller('singleController', function ($scope, $rootScope, $location, Candidat, $routeParams) {
    $rootScope.PAGE='single';
    $scope.candidat = {};
    $scope.candidat.types = {
        firstName: 'text',
        lastName: 'text',
        email: 'email',
        homePhone: 'tel',
        mobilePhone: 'tel',
        birthday: 'date',
        website: 'url',
        address: 'text',
        enrollmentDate: 'date'
    };
    $scope.candidat.values = Candidat.get({ id: parseInt($routeParams.id, 10) });
    $scope.delete = function () {
        $scope.candidat.values.$delete();
        $location.url('/candidats');
    };
});