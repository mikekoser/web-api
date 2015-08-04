/*global module:false*/
module.exports = function (grunt) {

	// Project configuration.
	grunt.initConfig({
		// Metadata.
		pkg: grunt.file.readJSON('package.json'),
		banner: '',
		// Task configuration.
		handlebars: {
			compile: {
				options: {
					namespace: 'WAS', // Doc App Templates
					processName: function (filePath) {
						return filePath.replace('templates/', '').replace('.handlebars', '');
					},
					partialRegex: /^p-/
				},
				files: {
					"js/hb-partials.js": ["templates/p-category.handlebars", "templates/p-action.handlebars", "templates/p-payload.handlebars", "templates/p-response.handlebars"],
					"js/hb-templates.js": ["templates/category-list.handlebars", "templates/primary-navigation.handlebars"]
				}
			}
		},
		concat: {
			options: {
				banner: '<%= banner %>',
				stripBanners: true
			},
			dist: {
				// the files to concatenate
				src: ['Scripts/jquery-1.10.2.js', 'Scripts/bootstrap.js'],
				// the location of the resulting JS file
				dest: 'dist/<%= pkg.name %>.js'
			},
			disthead: {
				// the files to concatenate
				src: ['Scripts/modernizr*.js'],
				// the location of the resulting JS file
				dest: 'dist/<%= pkg.name %>-head.js'
			}
		},
		uglify: {
			options: {
				banner: '<%= banner %>'
			},
			dist: {
				src: '<%= concat.dist.dest %>',
				dest: 'dist/<%= pkg.name %>.min.js'
			},
			disthead: {
				src: '<%= concat.disthead.dest %>',
				dest: 'dist/<%= pkg.name %>.-head.min.js'
			}
		},
		cssmin: {
			options: {
				shorthandCompacting: false,
				roundingPrecision: -1
			},
			target: {
				files: {
					'dist/style.mins.css': ['Content/bootstrap.css', 'Content/Site.css']
				}
			}
		}
	});

	// These plugins provide necessary tasks.
	//grunt.loadNpmTasks('grunt-contrib-handlebars');
	grunt.loadNpmTasks('grunt-contrib-concat');
	grunt.loadNpmTasks('grunt-contrib-uglify')
	grunt.loadNpmTasks('grunt-contrib-cssmin');
	// Default task.
	grunt.registerTask('default', ['concat', 'uglify', 'cssmin']);
};
