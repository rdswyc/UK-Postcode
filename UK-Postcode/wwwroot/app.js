(function () {
  'use strict';

  angular.module('app', [])
    .controller('Controller', function ($http) {
      var self = this;
      self.error = false;
      self.list = [];

      self.getAddress = function () {
        $http.get('address/' + self.postCode).then(function (response) {
          addAddress(response.data);
          self.error = false;
          self.postCode = '';
        }, function (response) {
          self.error = true;
        });
      };

      var addAddress = function (address) {
        address.postCode = self.postCode;
        address.distanceMI = Math.round(address.distanceMI);
        address.distanceKM = Math.round(address.distanceKM);
        self.list.push(address);
      };
    });
})();