# New ports collection makefile for:	texlive-perltex
# Date created:		26/01/2009 16:08:51
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	perltex
PORTREVISION=	1
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	Define LaTeX macros in terms of Perl code

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
