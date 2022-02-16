describe('Integração - OCR', () => {

    beforeEach(()=>{
        cy.visit('http://localhost:3000')
    })

    it('Deve logar e inserir a imagem OCR retornando o valor correto da mesma', () => {

        cy.get('.cabecalhoPrincipal-nav-login').should('exist')
        cy.get('.cabecalhoPrincipal-nav-login').click()

        cy.get('.input__login').first().type('paulo@email.com')
        cy.get('.input__login').last().type('123456789')

        cy.get('#btn__login').click()

        cy.get('input[type=file]').first().selectFile('src/assets/tests/equipamento (2).jpeg')

        cy.wait(4000)
        cy.get('.input__login').last().should('have.value', '1202529')

        cy.get('.input__login').first().type('Notebook Teste')
        cy.get('input[type=file]').last().selectFile('src/assets/tests/foto_note.jpg')

        cy.get('.btn__cadastro').click()

        cy.wait(4000)
        cy.get('.card div h4').last().should('have.text', 'Notebook Teste')
        cy.get('.excluir').last().click()

    })

})