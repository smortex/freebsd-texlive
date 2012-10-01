# New ports collection makefile for:	texlive-context-degrade
# Date created:		13/03/2010 04:21:33
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	context-degrade
PORTVERSION=	20110629
PORTEPOCH=	1
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Degrading JPEG images in ConTeXt.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/bibtex/bst/context/cont-ab.bst:${PORTSDIR}/print/texlive-context

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
