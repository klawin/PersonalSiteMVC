$(function () {
    $("#accordion").accordion();
});

/**
   * Testimonials slider
   */
new Swiper('.testimonials-slider', {
    speed: 600,
    loop: true,
    autoplay: {
        delay: 5000,
        disableOnInteraction: false
    },
    slidesPerView: 3,
    pagination: {
        el: '.swiper-pagination',
        type: 'bullets',
        clickable: true
    }
});