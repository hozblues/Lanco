let table = new DataTable('#Contact', {
    pageLength: 20,
    columnDefs: [
        { orderable: true, targets: [0,1,2] }, 
        { orderable: false, targets: '_all' } 
    ],
    lengthChange: false 
});