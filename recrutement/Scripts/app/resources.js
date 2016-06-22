angular.module('app')
.factory('Candidat', function ($resource) {
    return $resource('/api/Candidats/:id', { id: '@id' }, {
        'update': {method:'PUT'}
    });
//.factory('Candidat', function ($resource) {
//    return $resource('/api/Candidats', {}, {
//        query: { method: 'GET', param: {}, isArray: true }
//    });
});