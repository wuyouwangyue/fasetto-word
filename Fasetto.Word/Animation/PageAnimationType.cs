namespace Fasetto.Word
{
    /// <summary>
    ///Page 页面 出现/消失 的动画样式
    /// </summary>
    public enum PageAnimationType
    {
        /// <summary>
        /// 没有动画
        /// </summary>
        None,

        /// <summary>
        /// Page 从右侧滑动过来
        /// </summary>
        SlideAndFadeInFromRight,

        /// <summary>
        /// Page 从左侧滑动出去
        /// </summary>
        SlideAndFadeOutToleft = 2,
    }
}
