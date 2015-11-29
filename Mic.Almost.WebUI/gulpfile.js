/// <vs BeforeBuild='less, bundle' SolutionOpened='dev:watch, install' />
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
    bundleRoot: './Content/Bundles/'
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
    return gulp.src(paths.bundleRoot, { read: false })
    .pipe(rimraf());
});

gulp.task('bundle', function () {
    return runSequence('install', 'clean', 'bundle:main:scripts', 'bundle:main:styles', 'bundle:main:copy', 'bundle:vendor', 'bundle:copy');
});

gulp.task('dev:watch', function () {
    watch('./Content/Css/**/*.less', function () {
        runSequence('less', 'bundle:main:styles');
    });
    watch('./Content/App/**/*.js', function () {
        runSequence('bundle:main:scripts');
    });
    watch('./Content/App/**/*.html', function () {
        runSequence('bundle:main:copy');
    });
});

gulp.task('bundle:main:scripts', function () {
    return gulp.src('./Content/Bundles/bundle.main.scripts.config.js')
        .pipe(bundle())
        .pipe(bundle.results({ dest: paths.bundleRoot, fileName: 'scripts' }))
        .pipe(gulp.dest(paths.bundleRoot + 'assets'));
});

gulp.task('bundle:main:copy', function () {
    return gulp.src('./Content/Bundles/bundle.main.copy.config.js')
        .pipe(bundle())
        .pipe(bundle.results({ dest: paths.bundleRoot, fileName: 'main.copy' }))
        .pipe(gulp.dest(paths.bundleRoot));
});

gulp.task('bundle:main:styles', function () {
    return gulp.src('./Content/Bundles/bundle.main.styles.config.js')
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

gulp.task('bundle:copy', function () {
    return gulp.src('./Content/Bundles/bundle.copy.config.js')
        .pipe(bundle())
        .pipe(bundle.results({ dest: paths.bundleRoot, fileName: 'copy' }))
        .pipe(gulp.dest(paths.bundleRoot));
});



