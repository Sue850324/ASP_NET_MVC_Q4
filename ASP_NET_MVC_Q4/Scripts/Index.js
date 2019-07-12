 ;function getEmployee(dptId) {
    $.ajax
        ({
            url: '/Home/GetEmployee/' + dptId,
            type: 'get',
            success: function (data) {
                console.log(data);
                $('#Employee option').remove();
                $.each(data, function () {
                    $('#Employee').append($('<option></option>').attr("value", this.Id).text(this.Name));
                })
            }
        });
}
function submit() {
    $('#Check').text($('#Id option:selected').text() + ' : ' + $('#Employee option:selected').text());

}