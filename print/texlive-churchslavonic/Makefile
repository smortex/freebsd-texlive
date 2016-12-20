# $FreeBSD$

PORTNAME=	churchslavonic
PORTVERSION=	20161220
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Typeset documents in Church Slavonic language using Unicode

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/fonts/opentype/public/fonts-churchslavonic/FedorovskUnicode.otf:${PORTSDIR}/print/texlive-fonts-churchslavonic \
		${LOCALBASE}/share/texmf-dist/tex/generic/hyph-utf8/loadhyph/loadhyph-cu.tex:${PORTSDIR}/print/texlive-hyphen-churchslavonic \
		${LOCALBASE}/share/texmf-dist/tex/latex/etoolbox/etoolbox.sty:${PORTSDIR}/print/texlive-etoolbox \
		${LOCALBASE}/share/texmf-dist/bibtex/bib/oberdiek/oberdiek-bundle.bib:${PORTSDIR}/print/texlive-oberdiek \
		${LOCALBASE}/share/texmf-dist/tex/latex/xcolor/xcolor.sty:${PORTSDIR}/print/texlive-xcolor

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
