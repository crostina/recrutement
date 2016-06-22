angular.module('app')
    // uppercase first character
.filter('labelCase', function () {
    return function (input) {
        input = input.replace(/([A-Z])/g, ' $1');
        return input[0].toUpperCase() + input.slice(1);
    };
})
//camel case filter
.filter('camelCase', function () {
    return function (input) {
        return input.toLowerCase().replace(/ (\w)/g, function (match, letter) {
            return letter.toUpperCase();
        });
    };
})
//filtre des champ du formulaire
.filter('keyFilter', function () {
    return function (obj,query) {
        var result = {};
        angular.forEach(obj, function (val,key) {
            if (key !== query) {
                result[key] = val;
            }
        });
        return result;
    };
});