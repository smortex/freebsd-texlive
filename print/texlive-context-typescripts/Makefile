# New ports collection makefile for:	texlive-context-typescripts
# Date created:		13/03/2010 04:21:48
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	context-typescripts
PORTVERSION=	20120218
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Small modules to load various fonts for use in ConTeXt.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/bibtex/bst/context/cont-ab.bst:${PORTSDIR}/print/texlive-context

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
