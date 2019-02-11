<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pendientes.aspx.cs" Inherits="PruebaFamsa.Pendientes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Listado de Pendientes</title>
    <script src="https://code.jquery.com/jquery-3.2.1.min.js"></script><script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>

    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>


		

   
 
    <script type="text/javascript" src="https://cdn.datatables.net/v/bs4/dt-1.10.18/fh-3.1.4/r-2.2.2/rg-1.1.0/datatables.min.js"></script>

    <script type="text/javascript" src="./Scripts/Methods/Pendientes.js"></script>

   
    <script
		src = "https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/toastr.min.js">
	  </script>
      <link rel="stylesheet" type="text/css" href="https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/toastr.min.css"/>

</head>
<body>
 
      <form runat="server">
   <asp:ScriptManager ID="ScriptManager1" runat="server"  EnablePageMethods="true">      </asp:ScriptManager>
		  <!-- Modal-->
					  <div id="myModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true" class="modal fade text-left">
						<div role="document" class="modal-dialog">
						  <div class="modal-content">
							<div class="modal-header">
							  <h4 id="exampleModalLabel" class="modal-title">Agregar Pendiente</h4>
							  <button type="button" data-dismiss="modal" aria-label="Close" class="close"><span aria-hidden="true">×</span></button>
							</div>


						   
							<div class="modal-body">

								 <input type="hidden" id="txtId"  value="1"/>

	                             <p>Ingrese Nuevo Pendiente</p>
							
								
								 <div class="form-group row">
						  <label class="col-sm-3 form-control-label">Pendiente:</label>
						  <div class="col-sm-9">
							<input type="text" placeholder="Descripcion de pendiente" class="form-control" id="txtPendiente" required/>
						  </div>
						</div>

							 
							</div>
							<div class="modal-footer">
							  <button type="button" data-dismiss="modal" class="btn btn-secondary">Cancelar</button>
							  <button type="button"  class="btn btn-primary" id="btnGuardar" >Guardar Pendiente</button>
							</div>
						  </div>
						</div>
					  </div>

							  <!------ END MODAL ------->
	

      <!-- Page Header-->
		  <header class="page-header">
			<div class="container-fluid">
			  <h2 class="no-margin-bottom">Test de conocimiento - Abner Garcia</h2>
			</div>
		  </header>
		  <!-- Breadcrumb-->
		  <div class="breadcrumb-holder container-fluid">
			<ul class="breadcrumb">
			  <li class="breadcrumb-item"><a href="default">Home</a></li>
			  <li class="breadcrumb-item active">Listado de pendientes de usuario </li>
			</ul>
		  </div>
		  <!-- Forms Section-->
		  <section class="forms"> 
			<div class="container-fluid">
			  <div class="row">
				<!-- Basic Form-->
			
				<!-- Form Elements -->
				<div class="col-lg-12">
				  <div class="card">
					<div class="card-close">
					
					</div>
					<div class="card-header d-flex align-items-left">
					  <h3 class="h4">Total de Pendientes: </h3>
                        <h3 class="h4" id="txtTotalPendientes">0 </h3>
					</div>
					<div class="card-body " >
				   
						<!-----------------CARD BODY ------------------------------------->
					
					<button type="button" data-toggle="modal" data-target="#myModal" class="btn btn-primary" >Agregar nuevo pendiente </button>
					  
						<table  id="tblPendientes" class="table display table-striped table-bordered dt-responsive  hover" style="width:80%">
						  <thead>
							<tr>
							    <th>IdPendiente</th>
							    <th>Pendiente</th>
								<th>Status</th>
							    <th>Fecha de Creacion</th>
							    <th>Fecha de Actualizacion</th>
								<th>#Usuario</th>
								<th>Option</th>

							 
							</tr>
						  </thead>
						  <tbody>
						   
							  </tbody>
							</table>
					
	   



						<!-----------------END CARD BODY----------------------------------->
					</div>
				  </div>
				</div>
			  </div>
			</div>
		  </section>

          </form>
</body>
</html>
