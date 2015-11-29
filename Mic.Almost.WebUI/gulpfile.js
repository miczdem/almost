/// <binding BeforeBuild='bundle' />
var gulp = require('gulp');
var rimraf = require('gulp-rimraf');
var watch = require('gulp-watch');
var less = require('gulp-less');
var runSequence = require('run-sequence');
var bundle = require('gulp-bundle-assets');
var install = require("gulp-install");

var paths = {
    bower: './bower_components/',
    app: './Content/App/',
    images: './Content/Images/',
    bundleRoot: './Content/Bundles/',
    bundleCleanRoot: './Content/Bundles/assets'
};

gulp.task('install', function () {
    return gulp.src(['./bower.json', './package.json'])
        .pipe(install());
});

gulp.task('less', function () {
    return gulp.src('./Content/Css/style.less')
      .pipe(less())
      .pipe(gulp.dest('./Content/Css/'));
});

gulp.task('clean', function () {
    return gulp.src(paths.bundleCleanRoot, { read: false })
    .pipe(rimraf());
});

gulp.task('bundle', function () {
    return runSequence('install', 'clean', 'bundle:main', 'bundle:vendor');
});

gulp.task('bundle:main', function () {
    return gulp.src('./Content/Bundles/bundle.main.config.js')
        .pipe(bundle())
        .pipe(bundle.results({ dest: paths.bundleRoot, fileName: 'styles' }))
        .pipe(gulp.dest(paths.bundleRoot + 'assets'));
});

gulp.task('bundle:vendor', function () {
    return gulp.src('./Content/Bundles/bundle.vendor.config.js')
        .pipe(bundle())
        .pipe(bundle.results({ dest: paths.bundleRoot, fileName: 'vendor' }))
        .pipe(gulp.dest(paths.bundleRoot + 'assets'));
});


