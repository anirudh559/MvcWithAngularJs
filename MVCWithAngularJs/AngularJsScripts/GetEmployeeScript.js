/// <reference path="../Scripts/angular.js" />


var myapp = angular
    .module("mymodule", [])
    .controller("Mycontroller", function ($scope, $http, $window) {
        $http.get('http://localhost:51952/api/Customer/CustomerDetails')
        .then(function (response) {
            //alert(response.data)
            $scope.employees = response.data;
            //alert($scope.employees)
        })
        $scope.submitForm = function (formValid) {
            if ($('form').valid()) {
                alert("Form is valid")
            }
            else {
                alert("form is not valid")
            }
        };
});