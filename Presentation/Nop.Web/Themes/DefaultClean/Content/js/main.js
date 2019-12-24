$(document).ready(function () {
    $("#content-slider").lightSlider({
        loop: true,
        keyPress: true,
    });
    $('#image-gallery').lightSlider({
        gallery: true,
        item: 1,
        thumbItem: 9,
        slideMargin: 0,
        enableDrag: true,
        speed: 700,
        pauseOnHover: true,
        auto: true,
        loop: true,
        responsive: [
            {
                breakpoint: 800,
                settings: {
                    item: 1,
                    slideMove: 1,
                    slideMargin: 6,
                }
            },
            {
                breakpoint: 480,
                settings: {
                    item: 1,
                }
            }
        ],
        //   prevHtml:["<img src='images/banner/arrowpre.png'>"],
        //   nextHtml:["<img src='images/banner/arrownext.png'>"],
        onSliderLoad: function () {
            $('#image-gallery').removeClass('cS-hidden');
        }
    });

    $('.owl-carousel').owlCarousel({
        loop: true,
        margin: 10,
        responsiveClass: true,
        arrows: false,
        dots: false,
        responsive: {
            0: {
                items: 2,
                nav: true
            },
            600: {
                items: 3,
                nav: false
            },
            1000: {
                items: 5,
                nav: true,
                loop: false
            }
        }
    })
    $('.galary-mb-mb').owlCarousel({
        loop: true,
        margin: 10,
        nav: true,
        // autoplay:true,
        responsive: {
            0: {
                items: 2
            },
            
            600: {
                items: 3
            },
            1000: {
                items: 5
            }
        }
    })
    
    $(".aaa").mouseover(function () {
        $(".bbb").css("opacity", 0.2);
        // $(this).css("opacity", 1);
    })
    $(".aaa").mouseleave(function () {
        $(".bbb").css("opacity", 1);
    })
    $(function () {
        $('nav#menu').mmenu({
            extensions: ["position-right"]
        });
    });
    $('#menu li a').click(function () {

        //console.log("Clicked");
        $('#menu li a.active-2').removeClass('active-2');
        $(this).addClass('active-2');
    });
    $(window).scroll(function () {
        if ($(this).scrollTop() > 850) {
            $('.navi').addClass('fixed-2');
        } else {
            $('.navi').removeClass('fixed-2');
        }
    })
    $(window).scroll(function () {
        if ($(this).scrollTop() > 270) {
            $('.navi-2').addClass('fixed-2');
        } else {
            $('.navi-2').removeClass('fixed-2');
        }
    })
    $(".toggle-next ").click(function () {
        event.preventDefault();
        $(this).next().slideToggle();
        $(this).toggleClass('active');
    });
    
    $(".menu-toggle").click(function(){
        $(".menu-mb-navi").toggle();
    });
    $(".menu-mb-navi li a").click(function () {
        $(".menu-mb-navi").addClass('.close-item');
        $(".menu-mb-navi").toggle();
    });
      
    
    // $(".menu-toggle").click(function () {
    //     // $('menu-mb-navi').removeClass('show');
    //     $('menu-mb-navi').addClass('show');
    // });
    // $(".poi").on('mouseenter mouseleave', function () {
    //     $(this).find('.gray-overlay').fadeToggle(500);
    // });
});