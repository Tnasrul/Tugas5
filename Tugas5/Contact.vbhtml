@Code
    Layout = "~/_SiteLayout.vbhtml"
    PageData("Title") = "Contact"
End Code

<hgroup class="title">
    <h1>@PageData("Title").</h1>
    <h2>Your contact page.</h2>
</hgroup>
<div class="mb-3">
    <label for="exampleFormControllInput1" class="form-label">Email Address</label>
    <input type="email" class="form-control" id="exampleFormControllInput1" placeholder="nama@example.com">
</div>
<div class="mb-3">
    <label for="exampleFormControllTextArea1" class="form-label">Example Textarea</label>
    <textarea class="form-control" id="exampleFormControllTextarea1" rows="3"></textarea>
</div>
<select class="form-select" aria-label="Default select Example">
    <option selected>Open This Select Menu</option>
    <option value="1">One</option>
    <option value="2">Two</option>
    <option value="3">Three</option>
</select>
<div class="form-check">
    <input class="form-check-input" type="checkbox" value="" id="flexCheckDefault">
    <label class="form-check-label" for="flexCheckDefault">
        Default Checkbox
    </label>
</div>
<div class="form-check">
    <input class="form-check-input" type="checkbox" value="" id="flexCheckDefault" checked>
    <label class="form-check-label" for="flexCheckChecked">
        Checked Checkbox
    </label>
</div>

<button type="button" class="btn btn-primary">Primary</button>
<button type="button" class="btn btn-secondary">Secondary</button>
<button type="button" class="btn btn-success">Success</button>
<button type="button" class="btn btn-danger">Danger</button>
<button type="button" class="btn btn-warning">Warning</button>
<button type="button" class="btn btn-info">Info</button>
<button type="button" class="btn btn-light">Light</button>
<button type="button" class="btn btn-link">Link</button>