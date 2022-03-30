var files = ["ca-gregorian.json", "numbers.json", "timeZoneNames.json"]

for (var i = 0; i < files.length; i++) {
	var val, ajax;
	var ajax = new ej.base.Ajax('/Syncfusion2/cldr-data/it/' + files[i], 'GET', true);
	ajax.onSuccess = function (value) {
		ej.base.loadCldr(JSON.parse(value));
	};
	ajax.send();
}
