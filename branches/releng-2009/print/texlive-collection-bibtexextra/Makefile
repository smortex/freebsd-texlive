# New ports collection makefile for:	texlive-collection-bibtexextra
# Date created:		13/03/2010 04:23:51
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	collection-bibtexextra
PORTREVISION=	2
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@blogreen.org
COMMENT=	Extra BibTeX styles

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/bibtex/bst/aichej/aichej.bst:${PORTSDIR}/print/texlive-aichej \
		${LOCALBASE}/share/texmf-dist/tex/latex/amsrefs/amsrefs.sty:${PORTSDIR}/print/texlive-amsrefs \
		${LOCALBASE}/share/texmf-dist/tex/latex/apacite/apacite.sty:${PORTSDIR}/print/texlive-apacite \
		${LOCALBASE}/share/texmf-dist/bibtex/bst/apalike2/apalike2.bst:${PORTSDIR}/print/texlive-apalike2 \
		${LOCALBASE}/share/texmf-dist/bibtex/bib/beebe/gut.bib:${PORTSDIR}/print/texlive-beebe \
		${LOCALBASE}/share/texmf-dist/tex/latex/bibarts/bibarts.sty:${PORTSDIR}/print/texlive-bibarts \
		${LOCALBASE}/share/texmf-dist/bibtex/bst/bibexport/expkeys.bst:${PORTSDIR}/print/texlive-bibexport \
		${LOCALBASE}/share/texmf-dist/bibtex/bst/bibhtml/abbrvhtml.bst:${PORTSDIR}/print/texlive-bibhtml \
		${LOCALBASE}/share/texmf-dist/tex/latex/biblatex/biblatex.sty:${PORTSDIR}/print/texlive-biblatex \
		${LOCALBASE}/share/texmf-dist/tex/latex/biblatex-apa/american-apa.lbx:${PORTSDIR}/print/texlive-biblatex-apa \
		${LOCALBASE}/share/texmf-dist/tex/latex/biblatex-chem/bbx/chem-acs.bbx:${PORTSDIR}/print/texlive-biblatex-chem \
		${LOCALBASE}/share/texmf-dist/tex/latex/biblatex-chicago-notes-df/biblatex-chicago.sty:${PORTSDIR}/print/texlive-biblatex-chicago-notes-df \
		${LOCALBASE}/share/texmf-dist/tex/latex/biblatex-dw/bbx/authortitle-dw.bbx:${PORTSDIR}/print/texlive-biblatex-dw \
		${LOCALBASE}/share/texmf-dist/tex/latex/biblatex-historian/historian.bbx:${PORTSDIR}/print/texlive-biblatex-historian \
		${LOCALBASE}/share/texmf-dist/tex/latex/biblatex-nature/bbx/nature.bbx:${PORTSDIR}/print/texlive-biblatex-nature \
		${LOCALBASE}/share/texmf-dist/tex/latex/biblatex-philosophy/english-philosophy.lbx:${PORTSDIR}/print/texlive-biblatex-philosophy \
		${LOCALBASE}/share/texmf-dist/tex/latex/biblatex-science/bbx/science.bbx:${PORTSDIR}/print/texlive-biblatex-science \
		${LOCALBASE}/share/texmf-dist/tex/latex/biblist/biblist.sty:${PORTSDIR}/print/texlive-biblist \
		${LOCALBASE}/share/texmf-dist/tex/latex/bibtopic/bibtopic.sty:${PORTSDIR}/print/texlive-bibtopic \
		${LOCALBASE}/share/texmf-dist/tex/latex/bibtopicprefix/bibtopicprefix.sty:${PORTSDIR}/print/texlive-bibtopicprefix \
		${LOCALBASE}/share/texmf-dist/tex/latex/bibunits/bibunits.sty:${PORTSDIR}/print/texlive-bibunits \
		${LOCALBASE}/share/texmf-dist/tex/latex/breakcites/breakcites.sty:${PORTSDIR}/print/texlive-breakcites \
		${LOCALBASE}/share/texmf-dist/tex/latex/cell/cell.sty:${PORTSDIR}/print/texlive-cell \
		${LOCALBASE}/share/texmf-dist/tex/latex/chbibref/chbibref.sty:${PORTSDIR}/print/texlive-chbibref \
		${LOCALBASE}/share/texmf-dist/tex/latex/chicago/chicago.sty:${PORTSDIR}/print/texlive-chicago \
		${LOCALBASE}/share/texmf-dist/bibtex/bst/chicago-annote/chicago-annote.bst:${PORTSDIR}/print/texlive-chicago-annote \
		${LOCALBASE}/share/texmf-dist/bibtex/bst/chembst/ChemCommun.bst:${PORTSDIR}/print/texlive-chembst \
		${LOCALBASE}/share/texmf-dist/tex/latex/collref/collref.sty:${PORTSDIR}/print/texlive-collref \
		${LOCALBASE}/share/texmf-dist/tex/latex/compactbib/compactbib.sty:${PORTSDIR}/print/texlive-compactbib \
		${LOCALBASE}/share/texmf-dist/tex/latex/custom-bib/catalan.mbs:${PORTSDIR}/print/texlive-custom-bib \
		${LOCALBASE}/share/texmf-dist/bibtex/bib/din1505/leitbild.bib:${PORTSDIR}/print/texlive-din1505 \
		${LOCALBASE}/share/texmf-dist/tex/latex/dk-bib/dk-bib.sty:${PORTSDIR}/print/texlive-dk-bib \
		${LOCALBASE}/share/texmf-dist/tex/latex/doipubmed/doipubmed.sty:${PORTSDIR}/print/texlive-doipubmed \
		${LOCALBASE}/share/texmf-dist/bibtex/bst/elsevier-bib/elsart-harv.bst:${PORTSDIR}/print/texlive-elsevier-bib \
		${LOCALBASE}/share/texmf-dist/bibtex/bst/fbs/fbs.bst:${PORTSDIR}/print/texlive-fbs \
		${LOCALBASE}/share/texmf-dist/tex/latex/figbib/figbib.sty:${PORTSDIR}/print/texlive-figbib \
		${LOCALBASE}/share/texmf-dist/tex/latex/footbib/footbib.sty:${PORTSDIR}/print/texlive-footbib \
		${LOCALBASE}/share/texmf-dist/tex/latex/harvard/harvard.sty:${PORTSDIR}/print/texlive-harvard \
		${LOCALBASE}/share/texmf-dist/tex/plain/harvmac/harvmac.tex:${PORTSDIR}/print/texlive-harvmac \
		${LOCALBASE}/share/texmf-dist/tex/latex/historische-zeitschrift/bbx/historische-zeitschrift.bbx:${PORTSDIR}/print/texlive-historische-zeitschrift \
		${LOCALBASE}/share/texmf-dist/bibtex/bst/ijqc/ijqc.bst:${PORTSDIR}/print/texlive-ijqc \
		${LOCALBASE}/share/texmf-dist/tex/latex/inlinebib/inlinebib.sty:${PORTSDIR}/print/texlive-inlinebib \
		${LOCALBASE}/share/texmf-dist/bibtex/bst/iopart-num/iopart-num.bst:${PORTSDIR}/print/texlive-iopart-num \
		${LOCALBASE}/share/texmf-dist/tex/latex/jneurosci/jneurosci.sty:${PORTSDIR}/print/texlive-jneurosci \
		${LOCALBASE}/share/texmf-dist/tex/latex/jurabib/jurabib.sty:${PORTSDIR}/print/texlive-jurabib \
		${LOCALBASE}/share/texmf-dist/tex/latex/listbib/listbib.sty:${PORTSDIR}/print/texlive-listbib \
		${LOCALBASE}/share/texmf-dist/tex/latex/margbib/margbib.sty:${PORTSDIR}/print/texlive-margbib \
		${LOCALBASE}/share/texmf-dist/tex/latex/multibib/multibib.sty:${PORTSDIR}/print/texlive-multibib \
		${LOCALBASE}/share/texmf-dist/bibtex/bst/munich/munich.bst:${PORTSDIR}/print/texlive-munich \
		${LOCALBASE}/share/texmf-dist/tex/latex/notes2bib/notes2bib.sty:${PORTSDIR}/print/texlive-notes2bib \
		${LOCALBASE}/share/texmf-dist/bibtex/bst/perception/perception.bst:${PORTSDIR}/print/texlive-perception \
		${LOCALBASE}/share/texmf-dist/bibtex/bst/pnas2009/pnas2009.bst:${PORTSDIR}/print/texlive-pnas2009 \
		${LOCALBASE}/share/texmf-dist/tex/latex/rsc/rsc.sty:${PORTSDIR}/print/texlive-rsc \
		${LOCALBASE}/share/texmf-dist/bibtex/bst/sort-by-letters/abbrv-letters.bst:${PORTSDIR}/print/texlive-sort-by-letters \
		${LOCALBASE}/share/texmf-dist/tex/latex/splitbib/splitbib.sty:${PORTSDIR}/print/texlive-splitbib \
		${LOCALBASE}/share/texmf-dist/bibtex/bib/urlbst/urlbst.bib:${PORTSDIR}/print/texlive-urlbst \
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
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core \
		${LOCALBASE}/share/texmf-dist/fonts/source/public/latex-fonts/circle.mf:${PORTSDIR}/print/texlive-latex-fonts \
		${LOCALBASE}/share/texmf-dist/tex/latex/latexconfig/color.cfg:${PORTSDIR}/print/texlive-latexconfig \
		${LOCALBASE}/share/texmf-dist/tex/latex/ltxmisc/abstbook.cls:${PORTSDIR}/print/texlive-ltxmisc \
		${LOCALBASE}/share/texmf-dist/tex/latex/mfnfss/oldgerm.sty:${PORTSDIR}/print/texlive-mfnfss \
		${LOCALBASE}/share/texmf-dist/tex/latex/natbib/natbib.sty:${PORTSDIR}/print/texlive-natbib \
		${LOCALBASE}/share/texmf-dist/scripts/oberdiek/luacolor.lua:${PORTSDIR}/print/texlive-oberdiek \
		${LOCALBASE}/share/texmf-dist/tex/latex/pdftex-def/pdftex.def:${PORTSDIR}/print/texlive-pdftex-def \
		${LOCALBASE}/share/texmf-dist/tex/latex/pslatex/pslatex.sty:${PORTSDIR}/print/texlive-pslatex \
		${LOCALBASE}/share/texmf-dist/fonts/map/dvips/psnfss/charter.map:${PORTSDIR}/print/texlive-psnfss \
		${LOCALBASE}/share/texmf-dist/tex/latex/pspicture/pspicture.sty:${PORTSDIR}/print/texlive-pspicture \
		${LOCALBASE}/share/texmf-dist/tex/context/base/supp-pdf.tex:${PORTSDIR}/print/texlive-supp-pdf \
		${LOCALBASE}/share/texmf-dist/tex/latex/tools/.tex:${PORTSDIR}/print/texlive-tools \
		${LOCALBASE}/share/texmf-dist/tex/latex/amsfonts/amsfonts.sty:${PORTSDIR}/print/texlive-amsfonts \
		${LOCALBASE}/share/texmf-dist/tex/latex/apalike/apalike.sty:${PORTSDIR}/print/texlive-apalike \
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
		${LOCALBASE}/share/texmf/tex/generic/config/luatexiniconfig.tex:${PORTSDIR}/print/texlive-luatex \
		${LOCALBASE}/share/texmf-dist/makeindex/base/din.ist:${PORTSDIR}/print/texlive-makeindex \
		${LOCALBASE}/share/texmf-dist/metafont/base/expr.mf:${PORTSDIR}/print/texlive-metafont \
		${LOCALBASE}/share/texmf-dist/tex/latex/mflogo/mflogo.sty:${PORTSDIR}/print/texlive-mflogo \
		${LOCALBASE}/share/texmf-dist/mft/base/README:${PORTSDIR}/print/texlive-mfware \
		${LOCALBASE}/share/texmf-dist/fonts/source/public/misc/black.mf:${PORTSDIR}/print/texlive-misc \
		${LOCALBASE}/share/texmf/fonts/map/pdftex/updmap/pdftex.map:${PORTSDIR}/print/texlive-pdftex \
		${LOCALBASE}/share/texmf-dist/tex/plain/base/plain.tex:${PORTSDIR}/print/texlive-plain \
		${LOCALBASE}/share/texmf/dvips/tetex/config.builtin35:${PORTSDIR}/print/texlive-tetex \
		${LOCALBASE}/share/texmf/texconfig/README:${PORTSDIR}/print/texlive-texconfig \
		${LOCALBASE}/share/texmf/scripts/texlive/lua/texlive/getopt.tlu:${PORTSDIR}/print/texlive-texlive-scripts \
		${LOCALBASE}/share/texmf/scripts/texlive/tlmgr.pl:${PORTSDIR}/print/texlive-texlive.infra \
		${LOCALBASE}/share/texmf/xdvi/XDvi:${PORTSDIR}/print/texlive-xdvi

NOPORTDOCS=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
