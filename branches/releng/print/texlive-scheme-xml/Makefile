# New ports collection makefile for:	texlive-scheme-xml
# Date created:		13/03/2010 05:01:16
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	scheme-xml
PORTVERSION=	20100610
PORTEPOCH=	1
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@FreeBSD.org
COMMENT=	XML scheme

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/bibtex/bst/context/cont-ab.bst:${PORTSDIR}/print/texlive-context \
		${LOCALBASE}/share/texmf-dist/tex/jadetex/base/dsssl.def:${PORTSDIR}/print/texlive-jadetex \
		${LOCALBASE}/share/texmf-dist/tex/latex/ltxmisc/abstbook.cls:${PORTSDIR}/print/texlive-ltxmisc \
		${LOCALBASE}/share/texmf-dist/tex/latex/marvosym/marvosym.sty:${PORTSDIR}/print/texlive-marvosym \
		${LOCALBASE}/share/texmf-dist/fonts/afm/metapost/freeeuro.afm:${PORTSDIR}/print/texlive-metapost \
		${LOCALBASE}/share/texmf-dist/tex/xmltex/passivetex/dummyels.sty:${PORTSDIR}/print/texlive-passivetex \
		${LOCALBASE}/share/texmf-dist/tex/latex/rotating/rotating.sty:${PORTSDIR}/print/texlive-rotating \
		${LOCALBASE}/share/texmf-dist/tex/latex/stmaryrd/stmaryrd.sty:${PORTSDIR}/print/texlive-stmaryrd \
		${LOCALBASE}/share/texmf-dist/tex/generic/tex4ht/tex4ht.sty:${PORTSDIR}/print/texlive-tex4ht \
		${LOCALBASE}/share/texmf-dist/tex/latex/tipa/tipa.sty:${PORTSDIR}/print/texlive-tipa \
		${LOCALBASE}/share/texmf-dist/tex/latex/ucs/ucs.sty:${PORTSDIR}/print/texlive-ucs \
		${LOCALBASE}/share/texmf-dist/fonts/afm/public/wasy/wasy10.afm:${PORTSDIR}/print/texlive-wasy \
		${LOCALBASE}/share/texmf-dist/tex/latex/wasysym/wasysym.sty:${PORTSDIR}/print/texlive-wasysym \
		${LOCALBASE}/share/texmf-dist/tex/xmltex/base/xmltex.tex:${PORTSDIR}/print/texlive-xmltex \
		${LOCALBASE}/share/texmf/scripts/texlive/var/texcatalogue.keywords:${PORTSDIR}/print/texlive-texlive-docindex \
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
		${LOCALBASE}/share/texmf-dist/dvips/avantgar/config.uag:${PORTSDIR}/print/texlive-avantgar \
		${LOCALBASE}/share/texmf-dist/dvips/bookman/config.ubk:${PORTSDIR}/print/texlive-bookman \
		${LOCALBASE}/share/texmf-dist/fonts/afm/bitstrea/charter/bchb8a.afm:${PORTSDIR}/print/texlive-charter \
		${LOCALBASE}/share/texmf-dist/dvips/cm-super/cm-super.GS:${PORTSDIR}/print/texlive-cm-super \
		${LOCALBASE}/share/texmf-dist/fonts/source/public/cmextra/cmbxcd10.mf:${PORTSDIR}/print/texlive-cmextra \
		${LOCALBASE}/share/texmf-dist/dvips/courier/config.ucr:${PORTSDIR}/print/texlive-courier \
		${LOCALBASE}/share/texmf-dist/tex/latex/euro/euro.sty:${PORTSDIR}/print/texlive-euro \
		${LOCALBASE}/share/texmf-dist/fonts/source/public/euro-ce/ceit.mf:${PORTSDIR}/print/texlive-euro-ce \
		${LOCALBASE}/share/texmf-dist/tex/latex/eurosym/eurosym.sty:${PORTSDIR}/print/texlive-eurosym \
		${LOCALBASE}/share/texmf-dist/fonts/afm/public/fpl/fplbij8a.afm:${PORTSDIR}/print/texlive-fpl \
		${LOCALBASE}/share/texmf-dist/dvips/helvetic/config.uhv:${PORTSDIR}/print/texlive-helvetic \
		${LOCALBASE}/share/texmf-dist/fonts/afm/public/lm/lmb10.afm:${PORTSDIR}/print/texlive-lm \
		${LOCALBASE}/share/texmf-dist/fonts/opentype/public/lm-math/latinmodernmath-regular.otf:${PORTSDIR}/print/texlive-lm-math \
		${LOCALBASE}/share/texmf-dist/fonts/afm/public/mathpazo/fplmb.afm:${PORTSDIR}/print/texlive-mathpazo \
		${LOCALBASE}/share/texmf-dist/dvips/ncntrsbk/config.unc:${PORTSDIR}/print/texlive-ncntrsbk \
		${LOCALBASE}/share/texmf-dist/dvips/palatino/config.upl:${PORTSDIR}/print/texlive-palatino \
		${LOCALBASE}/share/texmf-dist/tex/latex/pxfonts/pxfonts.sty:${PORTSDIR}/print/texlive-pxfonts \
		${LOCALBASE}/share/texmf-dist/fonts/afm/public/rsfs/rsfs10.afm:${PORTSDIR}/print/texlive-rsfs \
		${LOCALBASE}/share/texmf-dist/dvips/symbol/config.usy:${PORTSDIR}/print/texlive-symbol \
		${LOCALBASE}/share/texmf-dist/fonts/afm/public/tex-gyre/qagb.afm:${PORTSDIR}/print/texlive-tex-gyre \
		${LOCALBASE}/share/texmf-dist/fonts/opentype/public/tex-gyre-math/texgyrepagellamath-regular.otf:${PORTSDIR}/print/texlive-tex-gyre-math \
		${LOCALBASE}/share/texmf-dist/dvips/times/config.utm:${PORTSDIR}/print/texlive-times \
		${LOCALBASE}/share/texmf-dist/tex/latex/txfonts/txfonts.sty:${PORTSDIR}/print/texlive-txfonts \
		${LOCALBASE}/share/texmf-dist/fonts/afm/adobe/utopia/putb8a.afm:${PORTSDIR}/print/texlive-utopia \
		${LOCALBASE}/share/texmf-dist/dvips/zapfchan/config.uzc:${PORTSDIR}/print/texlive-zapfchan \
		${LOCALBASE}/share/texmf-dist/dvips/zapfding/config.uzd:${PORTSDIR}/print/texlive-zapfding \
		${LOCALBASE}/share/texmf-dist/tex/latex/ae/ae.sty:${PORTSDIR}/print/texlive-ae \
		${LOCALBASE}/share/texmf-dist/bibtex/bst/amscls/amsalpha.bst:${PORTSDIR}/print/texlive-amscls \
		${LOCALBASE}/share/texmf-dist/tex/latex/amsmath/amsmath.sty:${PORTSDIR}/print/texlive-amsmath \
		${LOCALBASE}/share/texmf-dist/tex/generic/babel/babel.sty:${PORTSDIR}/print/texlive-babel \
		${LOCALBASE}/share/texmf-dist/tex/latex/babelbib/babelbib.sty:${PORTSDIR}/print/texlive-babelbib \
		${LOCALBASE}/share/texmf-dist/tex/latex/carlisle/dotlessj.sty:${PORTSDIR}/print/texlive-carlisle \
		${LOCALBASE}/share/texmf-dist/tex/latex/colortbl/colortbl.sty:${PORTSDIR}/print/texlive-colortbl \
		${LOCALBASE}/share/texmf-dist/tex/latex/fancyhdr/fancyhdr.sty:${PORTSDIR}/print/texlive-fancyhdr \
		${LOCALBASE}/share/texmf-dist/tex/latex/fix2col/fix2col.sty:${PORTSDIR}/print/texlive-fix2col \
		${LOCALBASE}/share/texmf-dist/tex/latex/geometry/geometry.sty:${PORTSDIR}/print/texlive-geometry \
		${LOCALBASE}/share/texmf-dist/tex/latex/graphics/graphics.sty:${PORTSDIR}/print/texlive-graphics \
		${LOCALBASE}/share/texmf-dist/tex/latex/hyperref/hyperref.sty:${PORTSDIR}/print/texlive-hyperref \
		${LOCALBASE}/share/texmf-dist/makeindex/latex/gglo.ist:${PORTSDIR}/print/texlive-latex \
		${LOCALBASE}/share/texmf-dist/fonts/source/public/latex-fonts/circle.mf:${PORTSDIR}/print/texlive-latex-fonts \
		${LOCALBASE}/share/texmf-dist/tex/latex/latexconfig/color.cfg:${PORTSDIR}/print/texlive-latexconfig \
		${LOCALBASE}/share/texmf-dist/tex/latex/mfnfss/oldgerm.sty:${PORTSDIR}/print/texlive-mfnfss \
		${LOCALBASE}/share/texmf-dist/tex/generic/context/mptopdf/mptopdf.tex:${PORTSDIR}/print/texlive-mptopdf \
		${LOCALBASE}/share/texmf-dist/tex/latex/natbib/natbib.sty:${PORTSDIR}/print/texlive-natbib \
		${LOCALBASE}/share/texmf-dist/bibtex/bib/oberdiek/oberdiek-bundle.bib:${PORTSDIR}/print/texlive-oberdiek \
		${LOCALBASE}/share/texmf-dist/tex/latex/pdftex-def/pdftex.def:${PORTSDIR}/print/texlive-pdftex-def \
		${LOCALBASE}/share/texmf-dist/tex/latex/pslatex/pslatex.sty:${PORTSDIR}/print/texlive-pslatex \
		${LOCALBASE}/share/texmf-dist/fonts/map/dvips/psnfss/charter.map:${PORTSDIR}/print/texlive-psnfss \
		${LOCALBASE}/share/texmf-dist/tex/latex/pspicture/pspicture.sty:${PORTSDIR}/print/texlive-pspicture \
		${LOCALBASE}/share/texmf-dist/tex/latex/tools/.tex:${PORTSDIR}/print/texlive-tools \
		${LOCALBASE}/share/texmf-dist/tex/lambda/antomega/antomega.sty:${PORTSDIR}/print/texlive-antomega \
		${LOCALBASE}/share/texmf-dist/tex/lambda/base/lambda.tex:${PORTSDIR}/print/texlive-lambda \
		${LOCALBASE}/share/texmf-dist/tex/latex/mxedruli/mxedruli.sty:${PORTSDIR}/print/texlive-mxedruli \
		${LOCALBASE}/share/texmf-dist/tex/plain/omega/omega.tex:${PORTSDIR}/print/texlive-omega

NOPORTDOCS=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
