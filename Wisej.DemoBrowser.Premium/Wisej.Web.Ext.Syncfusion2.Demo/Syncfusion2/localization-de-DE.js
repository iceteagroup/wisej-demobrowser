// load numbers, timezone, calendar, etc.
var culture = "de-DE";
var currency = "EUR";
var base = "./Syncfusion2/cldr-data/" + culture + "/";

$.when($.ajax({ url: base + "numbers.json" }),
	$.ajax({ url: base + "ca-gregorian.json" }),
	$.ajax({ url: base + "timeZoneNames.json" }),
	$.ajax({ url: base + "localeText.json" }))
	.done(function (numbers, calendar, timeZone, localeText) {

		ej.base.loadCldr(numbers[0]);
		ej.base.loadCldr(calendar[0]);
		ej.base.loadCldr(timeZone[0]);
		ej.base.L10n.load(localeText[0]);

		ej.base.setCulture(culture);
		ej.base.setCurrencyCode(currency);
	});