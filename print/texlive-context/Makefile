# New ports collection makefile for:	texlive-context
# Date created:		13/03/2010 04:21:16
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	context
PORTVERSION=	20111003
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	The ConTeXt macro package.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/fonts/afm/metapost/freeeuro.afm:${PORTSDIR}/print/texlive-metapost \
		${LOCALBASE}/share/texmf/fonts/map/pdftex/updmap/pdftex.map:${PORTSDIR}/print/texlive-pdftex \
		${LOCALBASE}/share/texmf-dist/fonts/misc/xetex/fontmapping/base/qx-unicode.map:${PORTSDIR}/print/texlive-xetex \
		${LOCALBASE}/share/texmf/tex/generic/config/luatex-unicode-letters.tex:${PORTSDIR}/print/texlive-luatex \
		${LOCALBASE}/share/texmf-dist/fonts/afm/public/lm/lmb10.afm:${PORTSDIR}/print/texlive-lm \
		${LOCALBASE}/share/texmf-dist/tex/latex/stmaryrd/stmaryrd.sty:${PORTSDIR}/print/texlive-stmaryrd \
		${LOCALBASE}/share/texmf-dist/tex/latex/amsfonts/amsfonts.sty:${PORTSDIR}/print/texlive-amsfonts \
		${LOCALBASE}/share/texmf-dist/tex/generic/context/mptopdf.tex:${PORTSDIR}/print/texlive-mptopdf \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
