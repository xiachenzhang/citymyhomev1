// Images and alt attribute
var images = {
    image: [
        { src: '../../Content/picture1.jpg', alt: 'Project 1' }
        , { src: '../../Content/picture2.jpg', alt: 'Project 2' }
        , { src: '../../Content/picture3.jpg', alt: 'Project 3' }
        , { src: '../../Content/picture4.jpg', alt: 'Project 4' }
        , { src: '../../Content/picture5.jpg', alt: 'Project 5' }
        , { src: '../../Content/picture6.jpg', alt: 'Project 6' }
  
    ]
};

// Show Modal Image 
function onClick(element) {
    document.getElementById("img").src = element.src;
    document.getElementById("modal").style.display = "block";
}