module.exports = {
    bundle: {
        "vendor-scripts": {
            scripts: [
                {
                    src: './bower_components/jquery/dist/jquery.js',
                    minSrc: './bower_components/jquery/dist/jquery.min.js'
                }, {
                    src: './bower_components/jquery-validation/dist/jquery.validate.js',
                    minSrc: './bower_components/jquery-validation/dist/jquery.validate.min.js'
                }, {
                    src: './bower_components/jquery-validation-unobtrusive/jquery.validate.unobtrusive.js',
                    minSrc: 'bower_components/jquery-validation-unobtrusive/jquery.validate.unobtrusive.min.js'
                }, {
                    src: './bower_components/bootstrap/dist/js/bootstrap.js',
                    minSrc: 'bower_components/bootstrap/dist/js/bootstrap.min.js'
                }, {
                    src: './bower_components/respond/dest/respond.src.js',
                    minSrc: './bower_components/respond/dest/respond.min.js'
                }
            ],
            options: {
                useMin: true,
                uglify: false,
                rev: true,
                maps: true
            }
        },
        "vendor-styles": {
            styles: [
                {
                    src: './bower_components/bootstrap/dist/css/bootstrap.css',
                    minSrc: './bower_components/bootstrap/dist/css/bootstrap.min.css'
                }
            ],
            options: {
                useMin: true,
                uglify: false,
                rev: true,
                maps: true
            }
        }
    }
};