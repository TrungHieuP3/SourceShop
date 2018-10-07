var MastterPageConfig = {
	status: false,
	statusMenu: false
}
var _MastterPage = {
	init: function(){
		_MastterPage.loadpage();
	},
	loadpage: function() {
		_MastterPage.registerEvent();
	},
	registerEvent: function () {
		$('.event-show').on('click', function(){
			MastterPageConfig.status = !MastterPageConfig.status;
			var li_show = $('#login-registration ul.navigation-bar');
			if(MastterPageConfig.status){
				li_show.addClass('_show');
			}
			else {
				li_show.removeClass('_show');
			}
		}),
		$('.event-show-menu').on('click', function(){
			MastterPageConfig.statusMenu = !MastterPageConfig.statusMenu;
			var li_show = $('#menu-bar ul.navigation-bar');
			if(MastterPageConfig.statusMenu){
				li_show.addClass('_show');
			}
			else {
				li_show.removeClass('_show');
			}
		})
	}
}

_MastterPage.init();