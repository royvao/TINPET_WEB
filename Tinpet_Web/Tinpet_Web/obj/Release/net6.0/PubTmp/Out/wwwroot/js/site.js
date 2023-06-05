// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


// Función para actualizar la visibilidad de los carruseles
function updateCarouselVisibility() {
	if ($(window).width() >= 600) {
		// Pantalla grande: mostrar el carrusel grande y ocultar el carrusel pequeño
		$('#carouselLarge').show();
		$('#carouselSmall').hide();
	} else {
		// Pantalla pequeña: mostrar el carrusel pequeño y ocultar el carrusel grande
		$('#carouselSmall').show();
		$('#carouselLarge').hide();
	}
}

// Actualizar la visibilidad de los carruseles al cargar la página
$(document).ready(updateCarouselVisibility);

// Actualizar la visibilidad de los carruseles cuando se cambia el tamaño de la ventana
$(window).resize(updateCarouselVisibility);

