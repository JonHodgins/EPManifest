function RenderMap(address, apiKey) {
    require([
        "esri/config",
        "esri/Map",
        "esri/views/MapView",
        "esri/widgets/Search"

    ], function (esriConfig, Map, MapView, Search) {
        esriConfig.apiKey = apiKey;

        const map = new Map({
            basemap: "arcgis-navigation"
        });

        const view = new MapView({
            container: "viewDiv",
            map: map,
            center: [-135.0568, 60.7212],
            zoom: 12
        });

        const searchWidget = new Search({
            view: view,
            searchTerm: address
        });

        view.when(() => {
            searchWidget.search();
        });
    });
}