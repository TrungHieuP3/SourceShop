var Orderconfig = {
	ratinglevel: 0,
}
var _OrderController = {
	init: function(){
		_OrderController.loadpage();
	},
	loadpage: function() {
		var data = {
			ProID: $('#img-product>img').attr('id')
		};
		$.ajax({
			url: './order/setRatingLevel.html',
			type: 'POST',
			dataType: 'json',
			data: data,
			success: function(response){
				if (response.status) {
					Orderconfig.ratinglevel = Math.round(response.ratinglevel);
					if(Orderconfig.ratinglevel == 0){
						$('.rating0').css({'display' : 'inline-block'});
						$('.star').css({'display' : 'none'});
					}
					else {
						$('.rating0').css({'display' : 'none'});
						$('.star').css({'display' : 'inline-block'});
						$.each(Orderconfig.ratinglevel, function (i, item) {
							var pos = i+1;
							var star = ".star-"+pos;
							$(star+"i").addClass('star-o');
						});
					}
					_OrderController.registerEvent();
				}
			}
		})
	},
	registerEvent: function () {
		
	}
}

_OrderController.init();