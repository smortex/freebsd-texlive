# $FreeBSD$

PORTNAME=	collection-langcjk
PORTVERSION=	20130327
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Chinese, Japanese, Korean

RUN_DEPENDS=	${LOCALBASE}/share/texmf/scripts/texlive/var/texcatalogue.keywords:${PORTSDIR}/print/texlive-texlive-docindex \
		${LOCALBASE}/share/texmf-dist/tex/latex/amsfonts/amsfonts.sty:${PORTSDIR}/print/texlive-amsfonts \
		${LOCALBASE}/share/texmf-dist/bibtex/bib/base/xampl.bib:${PORTSDIR}/print/texlive-bibtex \
		${LOCALBASE}/share/texmf-dist/fonts/map/dvips/cm/cmtext-bsr-interpolated.map:${PORTSDIR}/print/texlive-cm \
		${LOCALBASE}/share/texmf/dvipdfm/config/config:${PORTSDIR}/print/texlive-dvipdfm \
		${LOCALBASE}/share/texmf/dvipdfmx/dvipdfmx.cfg:${PORTSDIR}/print/texlive-dvipdfmx \
		${LOCALBASE}/share/texmf-dist/tex/latex/dvipdfmx-def/dvipdfmx.def:${PORTSDIR}/print/texlive-dvipdfmx-def \
		${LOCALBASE}/share/texmf-dist/dvips/base/ehandler.ps:${PORTSDIR}/print/texlive-dvips \
		${LOCALBASE}/share/texmf-dist/tex/generic/enctex/1250-csf.tex:${PORTSDIR}/print/texlive-enctex \
		${LOCALBASE}/share/texmf-dist/tex/plain/etex/etex.src:${PORTSDIR}/print/texlive-etex \
		${LOCALBASE}/share/texmf-dist/tex/latex/etex-pkg/etex.sty:${PORTSDIR}/print/texlive-etex-pkg \
		${LOCALBASE}/share/texmf-dist/fonts/map/glyphlist/glyphlist.txt:${PORTSDIR}/print/texlive-glyphlist \
		${LOCALBASE}/share/texmf/dvips/gsftopk/render.ps:${PORTSDIR}/print/texlive-gsftopk \
		${LOCALBASE}/share/texmf-dist/tex/generic/hyph-utf8/conversions/conv-utf8-ec.tex:${PORTSDIR}/print/texlive-hyph-utf8 \
		${LOCALBASE}/share/texmf/tex/generic/config/language.dat:${PORTSDIR}/print/texlive-hyphen-base \
		${LOCALBASE}/share/texmf-dist/tex/generic/oberdiek/ifluatex.sty:${PORTSDIR}/print/texlive-ifluatex \
		${LOCALBASE}/share/texmf-dist/tex/generic/ifxetex/ifxetex.sty:${PORTSDIR}/print/texlive-ifxetex \
		${LOCALBASE}/share/texmf/web2c/amiga-pl.tcx:${PORTSDIR}/print/texlive-kpathsea \
		${LOCALBASE}/share/texmf-dist/scripts/lua-alt-getopt/alt_getopt.lua:${PORTSDIR}/print/texlive-lua-alt-getopt \
		${LOCALBASE}/share/texmf/tex/generic/config/luatex-unicode-letters.tex:${PORTSDIR}/print/texlive-luatex \
		${LOCALBASE}/share/texmf-dist/makeindex/base/din.ist:${PORTSDIR}/print/texlive-makeindex \
		${LOCALBASE}/share/texmf-dist/metafont/base/expr.mf:${PORTSDIR}/print/texlive-metafont \
		${LOCALBASE}/share/texmf-dist/tex/latex/mflogo/mflogo.sty:${PORTSDIR}/print/texlive-mflogo \
		${LOCALBASE}/share/texmf-dist/mft/base/README:${PORTSDIR}/print/texlive-mfware \
		${LOCALBASE}/share/texmf-dist/fonts/source/public/misc/black.mf:${PORTSDIR}/print/texlive-misc \
		${LOCALBASE}/share/texmf-dist/scripts/simpdftex/simpdftex:${PORTSDIR}/print/texlive-pdftex \
		${LOCALBASE}/share/texmf-dist/tex/plain/base/plain.tex:${PORTSDIR}/print/texlive-plain \
		${LOCALBASE}/share/texmf-dist/scripts/tetex/allcm.sh:${PORTSDIR}/print/texlive-tetex \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core \
		${LOCALBASE}/share/texmf/scripts/tetex/texconfig.sh:${PORTSDIR}/print/texlive-texconfig \
		${LOCALBASE}/share/texmf/scripts/texlive/lua/texlive/getopt.tlu:${PORTSDIR}/print/texlive-texlive-scripts \
		${LOCALBASE}/share/texmf/scripts/texlive/tlmgr.pl:${PORTSDIR}/print/texlive-texlive.infra \
		${LOCALBASE}/share/texmf/xdvi/XDvi:${PORTSDIR}/print/texlive-xdvi \
		${LOCALBASE}/share/texmf-dist/fonts/cmap/adobemapping/LICENSE:${PORTSDIR}/print/texlive-adobemapping \
		${LOCALBASE}/share/texmf-dist/dvips/arphic/config.bkaiu:${PORTSDIR}/print/texlive-arphic \
		${LOCALBASE}/share/texmf-dist/tex/latex/bxbase/bxbase.sty:${PORTSDIR}/print/texlive-bxbase \
		${LOCALBASE}/share/texmf-dist/tex/latex/bxjscls/bxjsarticle.cls:${PORTSDIR}/print/texlive-bxjscls \
		${LOCALBASE}/share/texmf-dist/tex/latex/bxpict2e/bxdpxp2e.def:${PORTSDIR}/print/texlive-bxpict2e \
		${LOCALBASE}/share/texmf-dist/fonts/enc/dvips/c90/c90.enc:${PORTSDIR}/print/texlive-c90 \
		${LOCALBASE}/share/texmf-dist/tex/latex/cjk-ko/cjkutf8-josa.sty:${PORTSDIR}/print/texlive-cjk-ko \
		${LOCALBASE}/share/texmf-dist/tex/latex/cjk/contrib/wadalab/c42goth.fd:${PORTSDIR}/print/texlive-cjk \
		${LOCALBASE}/share/texmf-dist/tex/latex/cjkpunct/CJKpunct.sty:${PORTSDIR}/print/texlive-cjkpunct \
		${LOCALBASE}/share/texmf/hbf2gf/README:${PORTSDIR}/print/texlive-cjkutils \
		${LOCALBASE}/share/texmf-dist/fonts/misc/cns/4040w0.bin:${PORTSDIR}/print/texlive-cns \
		${LOCALBASE}/share/texmf-dist/tex/latex/ctex/ctex.sty:${PORTSDIR}/print/texlive-ctex \
		${LOCALBASE}/share/texmf-dist/fonts/sfd/dnp/DNP.sfd:${PORTSDIR}/print/texlive-dnp \
		${LOCALBASE}/share/texmf-dist/tex/latex/fonts-tlwg/fonts-tlwg.sty:${PORTSDIR}/print/texlive-fonts-tlwg \
		${LOCALBASE}/share/texmf-dist/dvips/garuda-c90/config.garuda-c90:${PORTSDIR}/print/texlive-garuda-c90 \
		${LOCALBASE}/share/texmf-dist/fonts/truetype/public/ipaex/ipaexg.ttf:${PORTSDIR}/print/texlive-ipaex \
		${LOCALBASE}/share/texmf-dist/tex/platex/japanese/japanese.ldf:${PORTSDIR}/print/texlive-japanese \
		${LOCALBASE}/share/texmf-dist/fonts/map/dvipdfmx/japanese-otf/otf-cktx.map:${PORTSDIR}/print/texlive-japanese-otf \
		${LOCALBASE}/share/texmf-dist/fonts/map/dvipdfmx/japanese-otf-uptex/otf-up-noEmbed.map:${PORTSDIR}/print/texlive-japanese-otf-uptex \
		${LOCALBASE}/share/texmf-dist/fonts/map/dvipdfmx/jfontmaps/otf-hiragino.map:${PORTSDIR}/print/texlive-jfontmaps \
		${LOCALBASE}/share/texmf-dist/tex/platex/jsclasses/jsarticle.cls:${PORTSDIR}/print/texlive-jsclasses \
		${LOCALBASE}/share/texmf-dist/tex/luatex/luatexja/luatexja.sty:${PORTSDIR}/print/texlive-luatexja \
		${LOCALBASE}/share/texmf-dist/dvips/norasi-c90/config.norasi-c90:${PORTSDIR}/print/texlive-norasi-c90 \
		${LOCALBASE}/share/texmf-dist/tex/ptex/base/ptex.tex:${PORTSDIR}/print/texlive-ptex \
		${LOCALBASE}/share/texmf-dist/scripts/ptex2pdf/ptex2pdf.lua:${PORTSDIR}/print/texlive-ptex2pdf \
		${LOCALBASE}/share/texmf-dist/tex/platex/pxbase/pxbase.sty:${PORTSDIR}/print/texlive-pxbase \
		${LOCALBASE}/share/texmf-dist/tex/platex/pxchfon/pxchfon.sty:${PORTSDIR}/print/texlive-pxchfon \
		${LOCALBASE}/share/texmf-dist/tex/latex/pxcjkcat/pxcjkcat.sty:${PORTSDIR}/print/texlive-pxcjkcat \
		${LOCALBASE}/share/texmf-dist/tex/platex/pxjahyper/pxjahyper.sty:${PORTSDIR}/print/texlive-pxjahyper \
		${LOCALBASE}/share/texmf-dist/tex/platex/pxrubrica/pxrubrica.sty:${PORTSDIR}/print/texlive-pxrubrica \
		${LOCALBASE}/share/texmf-dist/tex/generic/thailatex/hyph-th-utf8.tex:${PORTSDIR}/print/texlive-thailatex \
		${LOCALBASE}/share/texmf-dist/dvips/uhc/config.uhc:${PORTSDIR}/print/texlive-uhc \
		${LOCALBASE}/share/texmf-dist/tex/uptex/base/uptex.tex:${PORTSDIR}/print/texlive-uptex \
		${LOCALBASE}/share/texmf-dist/fonts/afm/wadalab/dgj/dgjgreek.afm:${PORTSDIR}/print/texlive-wadalab \
		${LOCALBASE}/share/texmf-dist/tex/latex/xpinyin/xpinyin.sty:${PORTSDIR}/print/texlive-xpinyin \
		${LOCALBASE}/share/texmf-dist/fonts/tfm/zhmetrics/cyberb/cyberb00.tfm:${PORTSDIR}/print/texlive-zhmetrics \
		${LOCALBASE}/share/texmf-dist/tex/latex/zhnumber/zhnumber.sty:${PORTSDIR}/print/texlive-zhnumber \
		${LOCALBASE}/share/texmf-dist/tex/xetex/zhspacing/generic/zhspacing.sty:${PORTSDIR}/print/texlive-zhspacing \
		${LOCALBASE}/share/texmf-dist/tex/latex/zxjafbfont/zxjafbfont.sty:${PORTSDIR}/print/texlive-zxjafbfont \
		${LOCALBASE}/share/texmf-dist/tex/latex/zxjafont/zxjafont.sty:${PORTSDIR}/print/texlive-zxjafont \
		${LOCALBASE}/share/texmf-dist/tex/latex/zxjatype/zxjatype.sty:${PORTSDIR}/print/texlive-zxjatype

NOPORTDOCS=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
