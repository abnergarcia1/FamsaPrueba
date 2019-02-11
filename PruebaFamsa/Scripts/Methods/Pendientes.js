
$(document).ready(function () {


    responsive();
    loadDataTables();

    $("#btnGuardar").click(function () {
        crearPendiente();
    });

    $('#txtPendiente').blur(function () {
        if ($(this).val().length === 0) {
            $(this).parents('p').addClass('warning');
        }
    });


    function responsive() {
        $('#tblPendientes').DataTable({
            "columnDefs": [
                {
                    "targets": [0],
                    "visible": true,

                },
                {
                    "targets": -1,
                    "data": "IdPendiente",
                    "defaultContent": "<button onclick='deleteRecord(this)'  type='button' class='btn btn-danger'>x</button>"
                }
            ],
            responsive: true,



        });



    }





    function crearPendiente() {


        var IdUsuario = $("#txtId").val();
        var Descripcion = $("#txtPendiente").val();
       

        if (Descripcion.length > 0) {

            // var pageUrl = '<%= ResolveUrl("~/Pendientes.aspx/CrearPendiente") %>';
            var pageUrl = "./Pendientes.aspx/CrearPendiente";

            $.ajax({
                type: "POST",
                url: pageUrl,

                data: JSON.stringify({ _Descripcion: Descripcion, _IdUsuario: IdUsuario }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (data) {

                    if (data.d == 1) {

                        $("#myModal").modal("hide");
                        clearModal();

                        loadDataTables();

                        toastr.success("Pendiente ha sido guardado");

                    }
                    else {
                        toastr.error("Pendiente no se logro guardar");
                    }
                }
            });
        }
        else {

            toastr.error("Ingrese descripcion de pendiente");


        }
        }
        
    




    function clearModal() {

       
        $("#txtPendiente").val("");
        



    }









});

function editRow(id) {

    loadCurrentItem(id);



}

function loadCurrentItem(id) {
    var pageUrl = '<%= ResolveUrl("~/configCustomers.aspx/LoadCustomer") %>';
    var objReturn;


    $.ajax({
        type: "POST",
        url: pageUrl,

        data: JSON.stringify({ _customerId: id }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {

            var customerinfo = JSON.parse(data.d);


            var obj = customerinfo[0];

            $("#txtId").val(obj.customer_id);
            $("#txtCustomer").val(obj.client_name);
            $("#txtAlias").val(obj.alias);
            $("#txtRFC").val(obj.rfc);
            $("#txtAddress").val(obj.rfc);
            $("#txtContact").val(obj.contact_name);
            $("#txtPhone").val(obj.phone);
            $("#txtEmail").val(obj.email);


            $("#myModal").modal("show");


        }

    })


}

function deleteRecord(id) {

    console.log(id);
    var pageUrl = "/Pendientes.aspx/EliminarPendiente";
    $.ajax({
        type: "POST",
        url: pageUrl,

        data: JSON.stringify({ _IdPendiente: id }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            if (data.d == 1) {



                toastr.success("Pendiente ha sido eliminado");
                loadDataTables();

            }
            else {
                toastr.error("Pendiente no se pudo eliminar");
            }
        }

    })




}

function loadDataTables() {


   // var pageUrl = '<%= ResolveUrl("~/Pendientes.aspx/CargarPendientesUsuario") %>';
    var pageUrl = "./Pendientes.aspx/CargarPendientesUsuario";

    $.ajax({
        type: "POST",
        url: pageUrl,

        data: JSON.stringify({ _IdUsuario: 1 }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {



            //   console.log(data.d);

          //  console.log(data.d);

            var table = $('#tblPendientes').dataTable({
                destroy: true,
                responsive: true,

                data: JSON.parse(data.d),
                columns: [

                    { data: "IdPendiente" },
                    { data: "Descripcion" },
                    { data: "Estatus" },

                    { data: "FechaCreacion" },
                    { data: "FechaActualizacion" },
                    {data:"IdUsuario"},
                  
                    { data: null },



                ],
                dom: 'Bfrtip',
                buttons: [
                    'copy', 'csv', 'excel', 'pdf', 'print'
                ],
                "columnDefs": [
                    {
                        "targets": [0],
                        "visible": false,

                    },
                    {
                        "targets": -1,
                        "data": "IdPendiente",

                        "render": function (data, type, row, meta) {


                            return "<button onclick='deleteRecord(" + data["IdPendiente"] + ")'  type='button' class='btn btn-danger'>X</button> ";

                        }
                    }
                ],

            });

            $("#txtTotalPendientes").html(Object.keys(JSON.parse(data.d)).length);

        },

        failure: function (response) {
            console.log(response.d);
        }

    });






}