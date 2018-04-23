# How to override the LayoutView painting mechanism


<p>Sometimes, the capabilities provided by the LayoutView for custom drawing isn't enough to achieve certain task. We have several requests for extending the custom drawing capabilities of the LayoutView. However, some features can be available at this time by creating the LayoutView descendant. This sample demonstrates some steps you need to perform to accomplish this task. As an example, we demonstrate for you how to draw a border around the card's field.</p>


<h3>Description</h3>

<p>Starting from version 9.2.4, the LayoutRepositoryItem...Painters are no longer used to draw editors. When an editor is not active, it is painted using the LayoutViewField...Painter.</p>

<br/>


