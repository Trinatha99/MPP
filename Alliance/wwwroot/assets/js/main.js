// mobile nav
const openBtn = document.querySelector("#nav-opn-btn");
const closeBtn = document.querySelector("#nav-cls-btn");
const offcanvasContainer = document.querySelector("#offcanvas-nav");

function openNav() {
  document.body.style.overflowY = "hidden";
  offcanvasContainer.classList.add("open");
}

function closeNav() {
  document.body.style.overflowY = "";
  offcanvasContainer.classList.remove("open");
}

openBtn.addEventListener("click", openNav);
closeBtn.addEventListener("click", closeNav);

$(window).scroll(function () {
  var scrolling = $(this).scrollTop();
  if (scrolling > 20) {
    $(".backto-top i").fadeIn(500);
  } else {
    $(".backto-top i").fadeOut(500);
  }

  if (scrolling > 50) {
    $(".menu_bg").addClass("nav-bg");
  } else {
    $(".menu_bg").removeClass("nav-bg");
  }
});

$(function () {
  $(".customers_slick").slick({
    slidesToShow: 5,
    slidesToScroll: 1,
    arrows: false,
    speed: 3000,
    autoplay: true,
    autoplaySpeed: 2000,

    responsive: [
      {
        breakpoint: 991,
        settings: {
          slidesToShow: 3,
        },
      },
      {
        breakpoint: 767,
        settings: {
          slidesToShow: 3,
        },
      },
    ],
  });

  // clients_slick
  $(".clients_slick").slick({
    slidesToShow: 3,
    slidesToScroll: 1,
    arrows: false,
    speed: 3000,
    autoplay: true,
    autoplaySpeed: 2000,
    responsive: [
      {
        breakpoint: 991,
        settings: {
          slidesToShow: 2,
        },
      },
      {
        breakpoint: 767,
        settings: {
          slidesToShow: 1,
        },
      },
    ],
  });
  // clients_slick
  $(".testimonails_slick").slick({
    slidesToShow: 1,
    slidesToScroll: 1,
    arrows: false,
    speed: 3000,
    autoplay: true,
    dots: true,
    autoplaySpeed: 2000,
    responsive: [
      {
        breakpoint: 991,
        settings: {
          slidesToShow: 2,
        },
      },
      {
        breakpoint: 767,
        settings: {
          slidesToShow: 1,
        },
      },
    ],
  });
  // clients_slick
  $(".team_slick").slick({
    slidesToShow: 4,
    slidesToScroll: 1,
    arrows: false,
    speed: 3000,
    autoplay: true,
    dots: true,
    autoplaySpeed: 2000,
    responsive: [
      {
        breakpoint: 1199,
        settings: {
          slidesToShow: 3,
        },
      },
      {
        breakpoint: 991,
        settings: {
          slidesToShow: 2,
        },
      },
      {
        breakpoint: 767,
        settings: {
          slidesToShow: 1,
        },
      },
    ],
  });
});

$(document).ready(function () {
  $("select").niceSelect();
});

//  AOS js
$(window).on("scroll", function () {
  AOS.init();
});
