/*!
* DevExtreme (dx.messages.en.js)
* Version: 19.2.4
* Build date: Tue Nov 19 2019
*
* Copyright (c) 2012 - 2019 Developer Express Inc. ALL RIGHTS RESERVED
* Read about DevExtreme licensing here: https://js.devexpress.com/Licensing/
*/
"use strict";

! function(root, factory) {
	if ("function" === typeof define && define.amd) {
		define(function(require) {
			factory(require("devextreme/localization"))
		})
	} else {
		if ("object" === typeof module && module.exports) {
			factory(require("devextreme/localization"))
		} else {
			factory(DevExpress.localization)
		}
	}
}(this, function(localization) {
	localization.loadMessages({
		en: {
			"dxCalendar-todayButtonText": "Go to Today",
		}
	})
});
