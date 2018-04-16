 //Componente de DevExpress LookUpEdit
 //Esta es una manera en la que se puede alimentar y configurar manualmente el componente
 
 /*para poder manejar los valores directamente desde el lookup debemos ingresar las columnas que seran las 
 que nos permitiran acceder a los valores.*/
 //En el diseño le instertamos las columnas, en Tareas de LookUp nos vamos a Edit Columns, Agregamos los campos key
 //que contendra la fuente de datos.Edit Columns tiene propiedades que podemos configurar yo solo puse el id como no visible
 //en esta caso le insertamos los campos Id, Descripcion ya que son los campos de la clase TipOperacion siendo esta misma
 //la fuente de datos.
 
 List<TiposOperacion> listaTiposOperacion = new List<TiposOperacion>();
                 listaTiposOperacion.Add(new TiposOperacion("0","Seleccione"));
                 listaTiposOperacion.Add(new TiposOperacion("3","003 - Prestación de Servicios Profesionales"));
                 listaTiposOperacion.Add(new TiposOperacion("6", "006 - Arrendamiento  de Inmuebles"));
                 lukTipoOperacion.Properties.ValueMember = "Id";//este valor no se mostrara ya que en el diseño ingrese una esta columna como invisible
                 lukTipoOperacion.Properties.DisplayMember = "Descripcion";
                 lukTipoOperacion.Properties.DataSource = listaTiposOperacion;//asignamos los datos, es importante que las columas que fueran creadas en el diseño tengan los mismo keys que la clase en este caso
                 lukTipoOperacion.EditValue = "0";//valor q mostrara al cargar los datos
                 
//clase para alimentar el componente
 private class TiposOperacion
             {
                 public string Id { get; set; }
                 public string Descripcion { get; set; }
                 public TiposOperacion(string id, string descripcion)
                 {
                     this.Id = id;
                     this.Descripcion = descripcion;
                 }
             }
             
