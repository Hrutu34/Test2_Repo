async function loadInvoice() {
    try {
        const res = await fetch('/api/invoice');
        if (!res.ok) {
            document.getElementById('invoice-container').innerText = 'Invoice not found';
            return;
        }
        const invoice = await res.json();
        renderInvoice(invoice);
    } catch (err) {
        document.getElementById('invoice-container').innerText = 'Error loading invoice';
    }
}

function renderInvoice(invoice) {
    const container = document.getElementById('invoice-container');
    container.innerHTML = '';
    // Support both PascalCase and camelCase property names from API responses
    const id = invoice.InvoiceID ?? invoice.invoiceID ?? '';
    const customer = invoice.CustomerName ?? invoice.customerName ?? '';
    const items = invoice.Items ?? invoice.items ?? [];

    const h2 = document.createElement('h2');
    h2.innerText = `Invoice #${id} - ${customer}`;
    container.appendChild(h2);

    const ul = document.createElement('ul');
    for (const item of items) {
        const name = item.Name ?? item.name ?? '';
        const price = item.Price ?? item.price ?? 0;
        const li = document.createElement('li');
        li.innerText = `${name} - $${parseFloat(price).toFixed(2)}`;
        ul.appendChild(li);
    }
    container.appendChild(ul);
}

loadInvoice();