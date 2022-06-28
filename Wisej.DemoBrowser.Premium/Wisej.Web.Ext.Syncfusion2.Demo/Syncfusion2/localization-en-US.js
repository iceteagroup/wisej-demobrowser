// load numbers, timezone, calendar, etc.
var culture = "en-US";
var currency = "USD";
var base = "./Syncfusion2/cldr-data/" + culture + "/";

$.when($.ajax({ url: base + "numbers.json" }),
	$.ajax({ url: base + "ca-gregorian.json" }),
	$.ajax({ url: base + "timeZoneNames.json" }))
	.done(function (numbers, calendar, timeZone) {

		ej.base.loadCldr(numbers[0]);
		ej.base.loadCldr(calendar[0]);
		ej.base.loadCldr(timeZone[0]);

		ej.base.setCulture(culture);
		ej.base.setCurrencyCode(currency);
	});