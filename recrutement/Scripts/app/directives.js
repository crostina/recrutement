angular.module('candidatApp')
.value('FieldTypes', {
    text: ['Text', 'Should be text'],
    email: ['Email', 'Should be email address'],
    number: ['Number', 'Should be a number'],
    date: ['Date', 'Should be a date'],
    datetime: ['Datetime', 'Should be a datetime'],
    time: ['Time', 'Should be a time'],
    month: ['Month', 'Should be a month'],
    week: ['Week', 'Should be a week'],
    url: ['URL', 'Should be a URL'],
    tel: ['Phone Number', 'Should be a phone number'],
    color: ['Color', 'Should be a color']
})
.directive('formField', function ($timeout,FieldTypes) {
    return {
        restrict: 'EA',
        templateUrl: '/Templates/form-field.html',
        replace: true,
        scope: {
            record: '=',
            field: '@',
            live: '@',
            required:'@'
        },
        link: function ($scope,element,attr) {
            $scope.types = FieldTypes;
            $scope.remove = function (field) {
                delete $scope.record.values[field];
                delete $scope.record.types[field];
                $scope.blurUpdate();
            };
            $scope.blurUpdate = function () {
                if ($scope.live !== 'false') {
                    $scope.record.values.$update(function (updatedRecord) {
                        $scope.record.values = updatedRecord;
                    });
                }
            };
            var saveTimeout;
            $scope.update = function () {
                $timeout.cancel(saveTimeout);
                saveTimeout = $timeout($scope.blurUpdate,1000);
            };
            
        }
    };
})
.directive('newField', function ($filter, FieldTypes) {
    return {
        restrict: 'EA',
        templateUrl: '/Templates/new-field.html',
        replace: true,
        scope:  {
            record:'=',
            live:'@'

        },
        require: '^form',
        link: function ($scope, element, attr, form) {
            $scope.types = FieldTypes;
            $scope.field = {};
            
            $scope.show = function (type) {
                $scope.field.type = type;
                $scope.display = true;
            };

            $scope.remove = function () {
                $scope.field = {};
                $scope.display = false;
            };
            $scope.add = function () {
                if (form.newField.$valid) {
                    $scope.record.values[$filter('camelCase')($scope.field.name)] = $scope.field.value;
                    $scope.record.types[$filter('camelCase')($scope.field.name)] = $scope.field.type;
                    $scope.remove();
                    if ($scope.live !== 'false') {
                        $scope.record.values.$update(function (updatedRecord) {
                            $scope.record.values = updatedRecord;
                        });
                    }
                }
            };
        }
    };
});