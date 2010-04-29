# New ports collection makefile for:	texlive-collection-htmlxml
# Date created:		26/01/2009 16:05:23
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	collection-htmlxml
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@blogreen.org
COMMENT=	HTML/SGML/XML support

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/jadetex/base/dsssl.def:${PORTSDIR}/print/texlive-jadetex \
		${LOCALBASE}/share/texmf-dist/tex/xmltex/passivetex/dummyels.sty:${PORTSDIR}/print/texlive-passivetex \
		${LOCALBASE}/share/texmf-dist/tex/generic/tex4ht/tex4ht.sty:${PORTSDIR}/print/texlive-tex4ht \
		${LOCALBASE}/share/texmf-dist/tex/xmltex/xmlplay/play.xmt:${PORTSDIR}/print/texlive-xmlplay \
		${LOCALBASE}/share/texmf-dist/tex/xmltex/base/xmltex.tex:${PORTSDIR}/print/texlive-xmltex \
		${LOCALBASE}/share/texmf/fmtutil/format.jadetex.cnf:${PORTSDIR}/print/texlive-bin-jadetex \
		${LOCALBASE}/share/texmf/fmtutil/format.xmltex.cnf:${PORTSDIR}/print/texlive-bin-xmltex \
		${LOCALBASE}/share/texmf-dist/bibtex/bib/ams/amsj.bib:${PORTSDIR}/print/texlive-ams \
		${LOCALBASE}/share/texmf-dist/tex/latex/amsfonts/amsfonts.sty:${PORTSDIR}/print/texlive-amsfonts \
		${LOCALBASE}/share/texmf-dist/bibtex/bib/base/xampl.bib:${PORTSDIR}/print/texlive-bibtex \
		${LOCALBASE}/share/texmf-dist/dvips/cm/config.cm:${PORTSDIR}/print/texlive-cm \
		${LOCALBASE}/share/texmf-dist/fonts/map/dvips/cmex/ttcmex.map:${PORTSDIR}/print/texlive-cmex \
		${LOCALBASE}/share/texmf-dist/dvips/base/ehandler.ps:${PORTSDIR}/print/texlive-dvips \
		${LOCALBASE}/share/texmf-dist/tex/generic/enctex/1250-csf.tex:${PORTSDIR}/print/texlive-enctex \
		${LOCALBASE}/share/texmf-dist/tex/plain/etex/etex.src:${PORTSDIR}/print/texlive-etex \
		${LOCALBASE}/share/texmf-dist/tex/latex/etex-pkg/etex.sty:${PORTSDIR}/print/texlive-etex-pkg \
		${LOCALBASE}/share/texmf-dist/tex/generic/hyph-utf8/conversions/conv-utf8-ec.tex:${PORTSDIR}/print/texlive-hyph-utf8 \
		${LOCALBASE}/share/texmf-dist/tex/generic/ifxetex/ifxetex.sty:${PORTSDIR}/print/texlive-ifxetex \
		${LOCALBASE}/share/texmf-dist/makeindex/base/din.ist:${PORTSDIR}/print/texlive-makeindex \
		${LOCALBASE}/share/texmf-dist/metafont/base/expr.mf:${PORTSDIR}/print/texlive-metafont \
		${LOCALBASE}/share/texmf-dist/tex/latex/mflogo/mflogo.sty:${PORTSDIR}/print/texlive-mflogo \
		${LOCALBASE}/share/texmf-dist/fonts/source/public/misc/black.mf:${PORTSDIR}/print/texlive-misc \
		${LOCALBASE}/share/texmf-dist/tex/plain/base/plain.tex:${PORTSDIR}/print/texlive-plain \
		${LOCALBASE}/share/texmf/tex/generic/config/language.dat:${PORTSDIR}/print/texlive-hyphen-base \
		${LOCALBASE}/share/texmf/web2c/amiga-pl.tcx:${PORTSDIR}/print/texlive-bin-kpathsea \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core \
		${LOCALBASE}/share/texmf/dvipdfm/config/config:${PORTSDIR}/print/texlive-bin-dvipdfm \
		${LOCALBASE}/share/texmf/dvipdfmx/dvipdfmx.cfg:${PORTSDIR}/print/texlive-bin-dvipdfmx \
		${LOCALBASE}/share/texmf/dvips/base/color.pro:${PORTSDIR}/print/texlive-bin-dvipsk \
		${LOCALBASE}/share/texmf/scripts/texlive/getnonfreefonts.pl:${PORTSDIR}/print/texlive-bin-getnonfreefonts \
		${LOCALBASE}/share/texmf/dvips/gsftopk/render.ps:${PORTSDIR}/print/texlive-bin-gsftopk \
		${LOCALBASE}/share/texmf/fmtutil/format.metafont.cnf:${PORTSDIR}/print/texlive-bin-metafont \
		${LOCALBASE}/share/texmf/dvips/tetex/config.builtin35:${PORTSDIR}/print/texlive-bin-tetex \
		${LOCALBASE}/share/texmf/fmtutil/fmtutil-hdr.cnf:${PORTSDIR}/print/texlive-bin-texlive \
		${LOCALBASE}/share/texmf/fmtutil/format.tex.cnf:${PORTSDIR}/print/texlive-bin-tex \
		${LOCALBASE}/share/texmf/texconfig/README:${PORTSDIR}/print/texlive-bin-texconfig \
		${LOCALBASE}/share/texmf/xdvi/XDvi:${PORTSDIR}/print/texlive-bin-xdvi \
		${LOCALBASE}/share/texmf-dist/tex/latex/dvipdfmx-def/dvipdfmx.def:${PORTSDIR}/print/texlive-dvipdfmx-def \
		${LOCALBASE}/share/texmf-dist/fonts/map/glyphlist/glyphlist.txt:${PORTSDIR}/print/texlive-glyphlist \
		${LOCALBASE}/share/texmf/fmtutil/format.luatex.cnf:${PORTSDIR}/print/texlive-luatex \
		${LOCALBASE}/share/texmf/fmtutil/format.pdftex.cnf:${PORTSDIR}/print/texlive-pdftex \
		${LOCALBASE}/share/texmf-dist/dvips/avantgar/config.uag:${PORTSDIR}/print/texlive-avantgar \
		${LOCALBASE}/share/texmf-dist/dvips/bookman/config.ubk:${PORTSDIR}/print/texlive-bookman \
		${LOCALBASE}/share/texmf-dist/fonts/afm/bitstrea/charter/bchb8a.afm:${PORTSDIR}/print/texlive-charter \
		${LOCALBASE}/share/texmf-dist/fonts/source/public/cmextra/cmbxcd10.mf:${PORTSDIR}/print/texlive-cmextra \
		${LOCALBASE}/share/texmf-dist/dvips/courier/config.ucr:${PORTSDIR}/print/texlive-courier \
		${LOCALBASE}/share/texmf-dist/tex/latex/euro/euro.sty:${PORTSDIR}/print/texlive-euro \
		${LOCALBASE}/share/texmf-dist/fonts/source/public/euro-ce/ceit.mf:${PORTSDIR}/print/texlive-euro-ce \
		${LOCALBASE}/share/texmf-dist/tex/latex/eurofont/eurofont.sty:${PORTSDIR}/print/texlive-eurofont \
		${LOCALBASE}/share/texmf-dist/tex/latex/eurosans/eurosans.sty:${PORTSDIR}/print/texlive-eurosans \
		${LOCALBASE}/share/texmf-dist/tex/latex/eurosym/eurosym.sty:${PORTSDIR}/print/texlive-eurosym \
		${LOCALBASE}/share/texmf-dist/fonts/afm/public/fpl/fplbij8a.afm:${PORTSDIR}/print/texlive-fpl \
		${LOCALBASE}/share/texmf-dist/dvips/helvetic/config.uhv:${PORTSDIR}/print/texlive-helvetic \
		${LOCALBASE}/share/texmf-dist/fonts/afm/public/lm/lmb10.afm:${PORTSDIR}/print/texlive-lm \
		${LOCALBASE}/share/texmf-dist/tex/latex/marvosym/marvosym.sty:${PORTSDIR}/print/texlive-marvosym \
		${LOCALBASE}/share/texmf-dist/fonts/afm/public/mathpazo/fplmb.afm:${PORTSDIR}/print/texlive-mathpazo \
		${LOCALBASE}/share/texmf-dist/dvips/ncntrsbk/config.unc:${PORTSDIR}/print/texlive-ncntrsbk \
		${LOCALBASE}/share/texmf-dist/dvips/palatino/config.upl:${PORTSDIR}/print/texlive-palatino \
		${LOCALBASE}/share/texmf-dist/tex/latex/pxfonts/pxfonts.sty:${PORTSDIR}/print/texlive-pxfonts \
		${LOCALBASE}/share/texmf-dist/fonts/afm/public/rsfs/rsfs10.afm:${PORTSDIR}/print/texlive-rsfs \
		${LOCALBASE}/share/texmf-dist/dvips/symbol/config.usy:${PORTSDIR}/print/texlive-symbol \
		${LOCALBASE}/share/texmf-dist/fonts/afm/public/tex-gyre/qagb.afm:${PORTSDIR}/print/texlive-tex-gyre \
		${LOCALBASE}/share/texmf-dist/dvips/times/config.utm:${PORTSDIR}/print/texlive-times \
		${LOCALBASE}/share/texmf-dist/fonts/tfm/ibm/timesnew/nntb7t.tfm:${PORTSDIR}/print/texlive-timesnew \
		${LOCALBASE}/share/texmf-dist/tex/latex/tipa/tipa.sty:${PORTSDIR}/print/texlive-tipa \
		${LOCALBASE}/share/texmf-dist/tex/latex/txfonts/txfonts.sty:${PORTSDIR}/print/texlive-txfonts \
		${LOCALBASE}/share/texmf-dist/fonts/afm/adobe/utopia/putb8a.afm:${PORTSDIR}/print/texlive-utopia \
		${LOCALBASE}/share/texmf-dist/fonts/afm/public/wasy/wasy10.afm:${PORTSDIR}/print/texlive-wasy \
		${LOCALBASE}/share/texmf-dist/tex/latex/wasysym/wasysym.sty:${PORTSDIR}/print/texlive-wasysym \
		${LOCALBASE}/share/texmf-dist/dvips/zapfchan/config.uzc:${PORTSDIR}/print/texlive-zapfchan \
		${LOCALBASE}/share/texmf-dist/dvips/zapfding/config.uzd:${PORTSDIR}/print/texlive-zapfding \
		${LOCALBASE}/share/texmf-dist/tex/latex/ae/ae.sty:${PORTSDIR}/print/texlive-ae \
		${LOCALBASE}/share/texmf-dist/tex/latex/amscls/amsart.cls:${PORTSDIR}/print/texlive-amscls \
		${LOCALBASE}/share/texmf-dist/tex/latex/amsmath/amsmath.sty:${PORTSDIR}/print/texlive-amsmath \
		${LOCALBASE}/share/texmf-dist/tex/latex/amsrefs/amsrefs.sty:${PORTSDIR}/print/texlive-amsrefs \
		${LOCALBASE}/share/texmf-dist/tex/generic/babel/babel.sty:${PORTSDIR}/print/texlive-babel \
		${LOCALBASE}/share/texmf-dist/tex/latex/babelbib/babelbib.sty:${PORTSDIR}/print/texlive-babelbib \
		${LOCALBASE}/share/texmf-dist/tex/latex/carlisle/blkarray.sty:${PORTSDIR}/print/texlive-carlisle \
		${LOCALBASE}/share/texmf-dist/tex/latex/colortbl/colortbl.sty:${PORTSDIR}/print/texlive-colortbl \
		${LOCALBASE}/share/texmf-dist/tex/latex/fancyhdr/fancyhdr.sty:${PORTSDIR}/print/texlive-fancyhdr \
		${LOCALBASE}/share/texmf-dist/tex/latex/geometry/geometry.sty:${PORTSDIR}/print/texlive-geometry \
		${LOCALBASE}/share/texmf-dist/tex/latex/graphics/graphics.sty:${PORTSDIR}/print/texlive-graphics \
		${LOCALBASE}/share/texmf-dist/tex/latex/hyperref/hyperref.sty:${PORTSDIR}/print/texlive-hyperref \
		${LOCALBASE}/share/texmf-dist/makeindex/latex/gglo.ist:${PORTSDIR}/print/texlive-latex \
		${LOCALBASE}/share/texmf-dist/fonts/afm/bluesky/latex-fonts/lasy10.afm:${PORTSDIR}/print/texlive-latex-fonts \
		${LOCALBASE}/share/texmf-dist/tex/latex/latexconfig/latex.ini:${PORTSDIR}/print/texlive-latexconfig \
		${LOCALBASE}/share/texmf-dist/tex/latex/ltxmisc/2in1.sty:${PORTSDIR}/print/texlive-ltxmisc \
		${LOCALBASE}/share/texmf-dist/tex/latex/mfnfss/oldgerm.sty:${PORTSDIR}/print/texlive-mfnfss \
		${LOCALBASE}/share/texmf-dist/tex/latex/natbib/natbib.sty:${PORTSDIR}/print/texlive-natbib \
		${LOCALBASE}/share/texmf-dist/scripts/oberdiek/luacolor.lua:${PORTSDIR}/print/texlive-oberdiek \
		${LOCALBASE}/share/texmf-dist/tex/latex/pdftex-def/pdftex.def:${PORTSDIR}/print/texlive-pdftex-def \
		${LOCALBASE}/share/texmf-dist/tex/latex/pslatex/pslatex.sty:${PORTSDIR}/print/texlive-pslatex \
		${LOCALBASE}/share/texmf-dist/fonts/map/dvips/psnfss/charter.map:${PORTSDIR}/print/texlive-psnfss \
		${LOCALBASE}/share/texmf-dist/tex/latex/pspicture/pspicture.sty:${PORTSDIR}/print/texlive-pspicture \
		${LOCALBASE}/share/texmf-dist/tex/latex/tools/.tex:${PORTSDIR}/print/texlive-tools \
		${LOCALBASE}/share/texmf/fmtutil/format.latex.cnf:${PORTSDIR}/print/texlive-bin-latex

NOPORTDOCS=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
