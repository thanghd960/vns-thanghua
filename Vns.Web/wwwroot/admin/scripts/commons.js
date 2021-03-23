const noImage = "/admin/images/no-images.jpeg";
function uploadImage(filesSelected){
    debugger;
    console.log(a);
    return "fdafdsa";
}
function encodeImageFileAsURL(filesSelected, callback) {
  debugger;
  if (filesSelected.length > 0) {
    var fileToLoad = filesSelected[0];

    var fileReader = new FileReader();

    fileReader.onload = function(fileLoadedEvent) {
      var srcData = fileLoadedEvent.target.result; // <--- data: base64
        callback(srcData)
    }
    fileReader.readAsDataURL(fileToLoad);
  }
}


function validateImageExtention (file){
  var idxDot = file.lastIndexOf(".") + 1;

  var extFile = fileName.substr(idxDot, file.length).toLowerCase();
}


function uploadImages(file, callback) {
    var formData = new FormData();
    formData.append("source", file);
    $.ajax({
      url: '/Media/UploadImage',
      data: formData,
      type: "POST",
      cache: false,
      processData: false,
      contentType: false,
      success: function (data) {
        callback(data);
      },
      error: function (passParams) {
        callback(passParams);
      }
  });
}


function invalidForm(id){
  var element = document.getElementById(id);
  element.classList.add("has-error");
  element.classList.remove("has-success");
}

function validForm(id){
    var element = document.getElementById(id);
    element.classList.remove("has-error");
    element.classList.add("has-success");
}