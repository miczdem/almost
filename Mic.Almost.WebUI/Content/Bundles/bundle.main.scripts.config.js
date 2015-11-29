module.exports = {
    bundle: {
        main: {
            scripts: [
                './Content/App/app.js',
                './Content/App/app.config.js',
                './Content/App/app.config.routes.js',
                './Content/App/shared/**/*.filter.js',
                './Content/App/shared/**/*.service.js',
                './Content/App/shared/**/*.directive.js',
                './Content/App/components/**/*.filter.js',
                './Content/App/components/**/*.filters.js',
                './Content/App/components/**/*.service.js',
                './Content/App/components/**/*.directive.js',
                './Content/App/components/**/*.directives.js',
                './Content/App/components/**/*.controller.js'
            ],
            options: {
                useMin: false,
                uglify: false,
                rev: false,
                maps: true
            }
        }
    },
    copy: [
        {
            src: './Content/App/**/*.html',
            base: './Content/App/'
        }
    ]

};
