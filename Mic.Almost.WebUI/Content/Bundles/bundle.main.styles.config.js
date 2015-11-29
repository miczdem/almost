module.exports = {
    bundle: {
        main: {
            styles: [
                './Content/Css/style.css'
            ],
            options: {
                useMin: true,
                uglify: true,
                rev: false,
                maps: true
            }
        }
    }
};
