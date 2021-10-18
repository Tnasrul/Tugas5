@Code
    Layout = "~/_SiteLayout.vbhtml"
    PageData("Title") = "About"
End Code

<hgroup class="title">
    <h1>@PageData("Title").</h1>
    <h2>Your app description page.</h2>
</hgroup>
<h1> h1. Bootstrap Heading </h1>
<h2> h2. Bootstrap Heading </h2>
<h3> h3. Bootstrap Heading </h3>
<h4> h4. Bootstrap Heading </h4>
<h5> h5. Bootstrap Heading </h5>
<h6> h6. Bootstrap Heading </h6>

<table class="table" border="1">
    <thead>
        <tr>
            <th scope="col">#</th>
            <th scope="col">First</th>
            <th scope="col">Last</th>
            <th scope="col">Handle</th>
            </tr>
        </thead>
    <tbody>
        <tr>
            <th scope="row">1</th>
            <td>Mark</td>
            <td>Otto</td>
            <td>mdo</td>
        </tr>
        <tr>
            <th scope="row">2</th>
            <td>Jacob</td>
            <td>Thornton</td>
            <td>fat</td>
        </tr>
        <tr>
            <th scope="row">3</th>
            <td colspan="2">Larry the bird</td>
            <td>twitter</td>
        </tr>
        </tbody>
    </table>
<div id="carouselExampleControls" class="carousel slide" data-bs-ride="carousel">
    <div class="carousel-inner">
        <div class="carousel-item active">
            <img src="~/Images/logo2.png" width="50" class="d-block w-100" alt="..." />
        </div>
        <div class="carousel-item">
            <img src="~/Images/logo2.png" width="50" class="d-block w-100" alt="..." />
        </div>
        <div class="carousel-item">
            <img src="~/Images/logo2.png" width="50" class="d-block w-100" alt="..." />
        </div>
    </div>
        <button class="carousel-control-prev" type="button" data-b-target="#carouselExampleControl" data-bs-slide="prev">
            <span class="carousel-control-prev-icon" aria-hidden="true"></span>
            <span class="visually-hidden">Previous</span>
        </button>
            <button class="carousel-control-next" type="button" data-b-target="#carouselExampleControl" data-bs-slide="next">
                <span class="carousel-control-next-icon" aria-hidden="true"></span>
                <span class="visually-hidden">Next</span>
            </button>
</div>
