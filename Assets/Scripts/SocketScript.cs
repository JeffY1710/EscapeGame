using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class SocketScript : XRSocketInteractor
{
    private ArticleDetail currentArticleDetail;
    public PriceScript priceScript;
    public UiPrice uiPrice;
    

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        currentArticleDetail = args.interactableObject.transform.GetComponent<ArticleDetail>();
        priceScript.addPrice(currentArticleDetail.price);
        priceScript.getTotal();
        uiPrice.updateDisplay();
    }

    protected override void OnSelectExited(SelectExitEventArgs args)
    {
        var articleDetail = args.interactableObject.transform.GetComponent<ArticleDetail>();
        priceScript.removePrice(currentArticleDetail.price);
        uiPrice.updateDisplay();
        if (articleDetail == currentArticleDetail)
        {
            currentArticleDetail = null;
        }
        priceScript.getTotal();
    }

    //public float getPrice()
    //{
    //    return currentArticleDetail != null ? currentArticleDetail.price : 0f; 
    //}

    //public string getTitle()
    //{
    //    return currentArticleDetail != null ? currentArticleDetail.title : "No object";
    //}
}
