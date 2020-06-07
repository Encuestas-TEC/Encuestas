var num = 0;
function addcheckbox()
{
   
    num++;
    i = num;
  
        var myPanel = $('  <div class="card card-question" ><div class="card-header" ><div class="group"> <input type="text" required="required" class="intpregunta"/><span class="highlight"></span><span class="bar"></span> <label class="lblpregunta">Pregunta '+i+'</label></div> </div><div class="card-body"> <div class="input-group mb-3"> <div class="input-group-prepend"><div class="input-group-text"><input type="checkbox"></div></div> <input type="text" class="form-control" placeholder="Escribe la respuesta"></div> <div class="input-group mb-3"><div class="input-group-prepend"><div class="input-group-text"><input type="checkbox"></div> </div><input type="text" class="form-control" placeholder="Escribe la respuesta"> </div><div class="input-group mb-3"><div class="input-group-prepend"><div class="input-group-text"><input type="checkbox"></div></div> <input type="text" class="form-control" placeholder="Escribe la respuesta"> </div><div class="input-group mb-3"><div class="input-group-prepend"> <div class="input-group-text"><input type="checkbox"></div> </div><input type="text" class="form-control" placeholder="Escribe la respuesta"> </div><div class="input-group mb-3"> <div class="input-group-prepend"><div class="input-group-text"> <input type="checkbox"> </div></div> <input type="text" class="form-control" placeholder="Escribe la respuesta"></div></div> <div class="card-footer text-muted"> <button type="button" class="btn btn-success btn-sm" onclick="addR()"><i class="fas fa-plus-circle"></i>Agregar</button></div></div>');
       
        myPanel.appendTo('#contentPanel');
}
function addcheckbox2()
{
  
    num++;
    i = num;
  
        var myPanel = $('  <div class="card card-question" ><div class="card-header" ><div class="group"> <input type="text" required="required" class="intpregunta"/><span class="highlight"></span><span class="bar"></span> <label class="lblpregunta">Pregunta '+i+'</label></div> </div><div class="card-body" id="'+i+'checkbox"><div class="input-group mb-3"> <div class="input-group-prepend"><div class="input-group-text"> <input type="checkbox"> </div>  </div> <input type="text" class="form-control" placeholder="Escribe la respuesta "></div> </div> <div class="card-footer text-muted"> <button type="button" class="btn btn-success btn-sm" onclick="checkboxoptionadd('+i+')"><i class="fas fa-plus-circle"></i>Agregar opción</button></div></div>');
       
        myPanel.appendTo('#contentPanel');
}
function addcheckbox3()
{
  
    num++;
    i = num;
  
        var myPanel = $(' <div class="card card-question" id="'+i+'checkbox"><div class="group" style="padding: 0 20px;"><input type="text" required="required" class="intpregunta"/><span class="highlight"></span><span class="bar"></span>  <label class="lblpregunta">Escribe la pregunta</label> </div>     <ul class="respuestasul" id="'+i+'ulans"> <li class="Respuestali" id="numans" >  <div style="float: left;"> <i class="far fa-square"></i> </div> <div style="float: left; width: 90%;"> <input type="text" required="required" placeholder="Escribe la opcion" class="intrespuesta"/>  </div><button type="button" class="close closeAns" style="float: left;width: 2%; margin: 0; padding: 0; margin-top: 5px;" data-target="#numans" data-dismiss="alert" aria-label="Close"> <span aria-hidden="true">&times;</span> </button> </li> <li class="Respuestali" id="numans2" > <div style="float: left;">  <i class="far fa-square"></i> </div><div style="float: left; width: 90%;"><input type="text" required="required" placeholder="Escribe la opcion" class="intrespuesta"/> </div><button type="button" class="close closeAns" style="float: left;width: 2%; margin: 0; padding: 0; margin-top: 5px;" data-target="#numans2" data-dismiss="alert" aria-label="Close"><span aria-hidden="true">&times;</span> </button></li></ul><div style="border-top: 1px solid #E4DDDC; padding-top: 5px; margin-top: 5px; padding-bottom: 5px;"> <div style="float: right;"> <button class="btn close"  style="padding-top: 12px; color: #333;" data-target="#'+i+'checkbox" data-dismiss="alert" aria-label="Close"><svg class="bi bi-trash" width="1em" height="1em" viewBox="0 0 16 16" fill="currentColor" xmlns="http://www.w3.org/2000/svg"><path d="M5.5 5.5A.5.5 0 016 6v6a.5.5 0 01-1 0V6a.5.5 0 01.5-.5zm2.5 0a.5.5 0 01.5.5v6a.5.5 0 01-1 0V6a.5.5 0 01.5-.5zm3 .5a.5.5 0 00-1 0v6a.5.5 0 001 0V6z"/><path fill-rule="evenodd" d="M14.5 3a1 1 0 01-1 1H13v9a2 2 0 01-2 2H5a2 2 0 01-2-2V4h-.5a1 1 0 01-1-1V2a1 1 0 011-1H6a1 1 0 011-1h2a1 1 0 011 1h3.5a1 1 0 011 1v1zM4.118 4L4 4.059V13a1 1 0 001 1h6a1 1 0 001-1V4.059L11.882 4H4.118zM2.5 3V2h11v1h-11z" clip-rule="evenodd"/></svg></button>  </div><button type="button" class="btn btn-outline-light text-dark" onclick="checkboxoptionadd2('+i+')" style="float: right; border-right: 1px solid #E4DDDC; margin-right: 15px; padding-right: 5px;"> <i class="fas fa-plus-circle"></i>Agregar opción</button> </div> </div>');
       
        myPanel.appendTo('#contentPanel');
}
function checkboxoptionadd(i) {
    t++;
  var radioOption =  $('  <div class="input-group mb-3"> <div class="input-group-prepend"><div class="input-group-text"> <input type="checkbox"> </div>  </div> <input type="text" class="form-control" placeholder="Escribe la respuesta "></div>');
    radioOption.appendTo('#'+i+'checkbox');
 
}
function checkboxoptionadd2(i) {
  t++;
var radioOption =  $('  <li class="Respuestali" id="'+i+''+t+'ans" ><div style="float: left;"><i class="far fa-square"></i></div><div style="float: left; width: 90%;"><input type="text" required="required" placeholder="Escribe la opcion" class="intrespuesta"/></div><button type="button" class="close closeAns" style="float: left;width: 2%; margin: 0; padding: 0; margin-top: 5px;" data-target="#'+i+''+t+'ans" data-dismiss="alert" aria-label="Close"><span aria-hidden="true">&times;</span></button></li>');
  radioOption.appendTo('#'+i+'ulans');

}
var t=1;
function addradio2()
{
   
    num++;
    i = num;
 
        var myPanel = $(' <div class="card card-question" ><div class="card-header" ><div class="group"> <input type="text" required="required" class="intpregunta"/><span class="highlight"></span><span class="bar"></span> <label class="lblpregunta">Pregunta '+i+'</label></div> </div><div class="card-body" id="'+i+'radio"><div class="input-group mb-3"> <div class="input-group-prepend"><div class="input-group-text"> <input type="radio" name="inlineRadioOptions'+i+'" id="inlineRadio'+t+'" value="option'+t+'"> </div>  </div><input type="text" class="form-control" placeholder="Escribe la respuesta"> </div> </div><div class="card-footer text-muted"> <button type="button" class="btn btn-success btn-sm" onclick="radiooptionadd('+i+')"><i class="fas fa-plus-circle"></i>Agregar opción</button></div></div>');
       
        myPanel.appendTo('#contentPanel');
        
}
function addradio3()
{
   
    num++;
    i = num;
 
        var myPanel = $('<div class="card card-question" id="'+i+'radio"> <div class="group" style="padding: 0 20px;"> <input type="text" required="required" class="intpregunta"/> <span class="highlight"></span><span class="bar"></span> <label class="lblpregunta">Pregunta '+i+'</label> </div>   <ul class="respuestasul" id="'+i+'ulans"> <li class="Respuestali" id="radioans1" ><div style="float: left;"><i class="far fa-circle" ></i> </div><div style="float: left; width: 90%;"><input type="text" required="required" placeholder="Escribe la opcion" class="intrespuesta"/> </div> <button type="button" class="close closeAns" style="float: left;width: 2%; margin: 0; padding: 0; margin-top: 5px;" data-target="#radioans1" data-dismiss="alert" aria-label="Close"> <span aria-hidden="true">&times;</span> </button> </li><li class="Respuestali" id="radioans2" ><div style="float: left;"><i class="far fa-circle" ></i> </div><div style="float: left; width: 90%;"> <input type="text" required="required" placeholder="Escribe la opcion" class="intrespuesta"/> </div> <button type="button" class="close closeAns" style="float: left;width: 2%; margin: 0; padding: 0; margin-top: 5px;" data-target="#radioans2" data-dismiss="alert" aria-label="Close"> <span aria-hidden="true">&times;</span> </button> </li> </ul> <div style="border-top: 1px solid #E4DDDC; padding-top: 5px; margin-top: 5px; padding-bottom: 5px;"> <div style="float: right;"> <button class="btn close" style="padding-top: 12px; color: #333;" data-target="#'+i+'radio" data-dismiss="alert" aria-label="Close"><svg class="bi bi-trash" width="1em" height="1em" viewBox="0 0 16 16" fill="currentColor" xmlns="http://www.w3.org/2000/svg"> <path d="M5.5 5.5A.5.5 0 016 6v6a.5.5 0 01-1 0V6a.5.5 0 01.5-.5zm2.5 0a.5.5 0 01.5.5v6a.5.5 0 01-1 0V6a.5.5 0 01.5-.5zm3 .5a.5.5 0 00-1 0v6a.5.5 0 001 0V6z"/><path fill-rule="evenodd" d="M14.5 3a1 1 0 01-1 1H13v9a2 2 0 01-2 2H5a2 2 0 01-2-2V4h-.5a1 1 0 01-1-1V2a1 1 0 011-1H6a1 1 0 011-1h2a1 1 0 011 1h3.5a1 1 0 011 1v1zM4.118 4L4 4.059V13a1 1 0 001 1h6a1 1 0 001-1V4.059L11.882 4H4.118zM2.5 3V2h11v1h-11z" clip-rule="evenodd"/> </svg> </button> </div><div  style="float: right; border-right: 1px solid #E4DDDC; margin-right: 15px; padding-right: 5px;" ><button class="btn btn-light" onclick="radiooptionadd2('+i+')" > <i class="fas fa-plus-circle"></i><label for=""> Agregar opción </label> </button> </div> </div> </div>');
       
        myPanel.appendTo('#contentPanel');
        
}
function radiooptionadd(i) {
    t++;
  var radioOption =  $('<div class="input-group mb-3"> <div class="input-group-prepend"><div class="input-group-text"> <input type="radio" name="inlineRadioOptions'+i+'" id="inlineRadio'+t+'" value="option'+t+'"> </div>  </div><input type="text" class="form-control" placeholder="Escribe la respuesta"> </div>');
    radioOption.appendTo('#'+i+'radio');

}
function radiooptionadd2(i) {
  t++;
var radioOption =  $('  <li class="Respuestali" id="'+i+''+t+'ans" ><div style="float: left;"> <i class="far fa-circle" ></i></div><div style="float: left; width: 90%;"><input type="text" required="required" placeholder="Escribe la opcion" class="intrespuesta"/></div><button type="button" class="close closeAns" style="float: left;width: 2%; margin: 0; padding: 0; margin-top: 5px;" data-target="#'+i+''+t+'ans" data-dismiss="alert" aria-label="Close"><span aria-hidden="true">&times;</span></button></li>');
radioOption.appendTo('#'+i+'ulans');

}
function addTextArea()
{
  
    num++;
    i = num;
  
        var myPanel = $('<div class="card card-question" style="margin-left: 5em; margin-right: 5em; margin-top: 1em;"> <div class="card-header" ><div class="group"> <input type="text" asp-for required="required" class="intpregunta"/><span class="highlight"></span><span class="bar"></span> <label class="lblpregunta">Pregunta '+i+'</label></div> </div> <div class="card-body"> <section class="OpcionTextArea"><div class="form-group"><textarea class="form-control" id="exampleFormControlTextarea1" rows="3"></textarea>  </div></div></div>');
       
        myPanel.appendTo('#contentPanel');
}
function addTextArea2()
{
  
    num++;
    i = num;
  
        var myPanel = $(' <div class="card card-question" id="'+i+'textarea"> <div class="group" style="padding: 0 20px;"> <input type="text" required="required" class="intpregunta"/>  <span class="highlight"></span> <span class="bar"></span> <label class="lblpregunta">Escribre la pregunta</label> </div>      <section class="OpcionTextArea" ><div class="form-group"><textarea class="form-control" id="exampleFormControlTextarea1" rows="3"></textarea>  </section> <div style="border-top: 1px solid #E4DDDC; padding-top: 5px; margin-top: 5px; padding-bottom: 5px;"> <div style="float: right;"> <button class="btn close"  style="padding-top: 12px; color: #333;" data-target="#'+i+'textarea" data-dismiss="alert" aria-label="Close">  <svg class="bi bi-trash" width="1em" height="1em" viewBox="0 0 16 16" fill="currentColor" xmlns="http://www.w3.org/2000/svg"> <path d="M5.5 5.5A.5.5 0 016 6v6a.5.5 0 01-1 0V6a.5.5 0 01.5-.5zm2.5 0a.5.5 0 01.5.5v6a.5.5 0 01-1 0V6a.5.5 0 01.5-.5zm3 .5a.5.5 0 00-1 0v6a.5.5 0 001 0V6z"/> <path fill-rule="evenodd" d="M14.5 3a1 1 0 01-1 1H13v9a2 2 0 01-2 2H5a2 2 0 01-2-2V4h-.5a1 1 0 01-1-1V2a1 1 0 011-1H6a1 1 0 011-1h2a1 1 0 011 1h3.5a1 1 0 011 1v1zM4.118 4L4 4.059V13a1 1 0 001 1h6a1 1 0 001-1V4.059L11.882 4H4.118zM2.5 3V2h11v1h-11z" clip-rule="evenodd"/> </svg> </button> </div></div> </div>');
       
        myPanel.appendTo('#contentPanel');
}
function addRange()
{
  
    num++;
    i = num;
  
        var myPanel = $('  <div class="card card-question" style="margin-left: 5em; margin-right: 5em; margin-top: 1em;"> <div class="card-header" ><div class="group"> <input type="text" required="required" class="intpregunta"/><span class="highlight"></span><span class="bar"></span> <label class="lblpregunta">Pregunta '+i+'</label></div> </div> <div class="card-body">  <div class="range-slider"><input class="range-slider__range" type="range" value="1" min="1" max="10"> <span class="range-slider__value">0</span> </div> </div> </div>');
       
        myPanel.appendTo('#contentPanel');
        
   var rangeSlider = function(){
    var slider = $('.range-slider'),
        range = $('.range-slider__range'),
        value = $('.range-slider__value');
      
    slider.each(function(){
  
      value.each(function(){
        var value = $(this).prev().attr('value');
        $(this).html(value);
      });
  
      range.on('input', function(){
        $(this).next(value).html(this.value);
      });
    });
  };
  
  rangeSlider();
}
function addRange2()
{
  
    num++;
    i = num;
  
        var myPanel = $(' <div class="card card-question" id="'+i+'range"><div class="group" style="padding: 0 20px;">  <input type="text" required="required" class="intpregunta"/> <span class="highlight"></span> <span class="bar"></span><label class="lblpregunta">Escriba una pregunta </label> </div>   <div class="ansContainer"> <div class="range-slider" ><input class="range-slider__range" type="range" value="1" min="1" max="10"> <span class="range-slider__value">0</span> </div></div> <div style="border-top: 1px solid #E4DDDC; padding-top: 5px; margin-top: 5px; padding-bottom: 5px;"><div style="float: right;"><button class="btn close" style="padding-top: 12px; color: #333;"  data-target="#'+i+'range" data-dismiss="alert" aria-label="Close"><svg class="bi bi-trash" width="1em" height="1em" viewBox="0 0 16 16" fill="currentColor" xmlns="http://www.w3.org/2000/svg"> <path d="M5.5 5.5A.5.5 0 016 6v6a.5.5 0 01-1 0V6a.5.5 0 01.5-.5zm2.5 0a.5.5 0 01.5.5v6a.5.5 0 01-1 0V6a.5.5 0 01.5-.5zm3 .5a.5.5 0 00-1 0v6a.5.5 0 001 0V6z"/><path fill-rule="evenodd" d="M14.5 3a1 1 0 01-1 1H13v9a2 2 0 01-2 2H5a2 2 0 01-2-2V4h-.5a1 1 0 01-1-1V2a1 1 0 011-1H6a1 1 0 011-1h2a1 1 0 011 1h3.5a1 1 0 011 1v1zM4.118 4L4 4.059V13a1 1 0 001 1h6a1 1 0 001-1V4.059L11.882 4H4.118zM2.5 3V2h11v1h-11z" clip-rule="evenodd"/> </svg></button> </div> </div> </div>');
         myPanel.appendTo('#contentPanel');
        
   var rangeSlider = function(){
    var slider = $('.range-slider'),
        range = $('.range-slider__range'),
        value = $('.range-slider__value');
      
    slider.each(function(){
  
      value.each(function(){
        var value = $(this).prev().attr('value');
        $(this).html(value);
      });
  
      range.on('input', function(){
        $(this).next(value).html(this.value);
      });
    });
  };
  
  rangeSlider();
}

function deleteitem(id) {
delete id; 
}
// $('.close').on('click', function(e){
//       e.stopPropagation();  
//           var $target = $(this).parents('#contentPanel');
//           $target.hide('slow', function(){ $target.remove(); });
//     });