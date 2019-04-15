//set width of chart bar from attr data-bar-value after 200ms
setTimeout( function(){
    sizeBarChart();
}, 200);

function sizeBarChart() {
  $('.chart-bar').each(function(){
    $(this).css("width", $(this).data('bar-value'));
  });
}

