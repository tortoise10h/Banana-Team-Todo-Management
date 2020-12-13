/** Enable tool tips */
$(function () {
  $('[data-toggle="tooltip"]').tooltip();

  var url = window.location.pathname.replace(/\/$/, "");
  // Create regexp to match current url pathname
  var urlRegExp = new RegExp(`${url.length > 0 ? url : "/" }|\\?[\\s\\S]{1,}`);
  // Grab every link from the navigation
  $(".side-nav li").each(function () {
      const linkElement = $(this).children()[0];
      // Test its normalized href against the url pathname regexp
    if (linkElement) {
      const href = linkElement.href.replace(window.location.origin, "");
      const matchString = href.match(urlRegExp)
      if (matchString && matchString[0] === matchString.input) {
        $(this).addClass("mm-active");
      }
    }
  });
});
